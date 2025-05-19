-- Tabelas principais

CREATE TABLE Usuarios ( 
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
    email VARCHAR(100),
    senha_hash VARCHAR(255),
    tipo ENUM('admin', 'morador', 'visitante') DEFAULT 'morador',
    pontos INT DEFAULT 0 -- usado para acumular pontos semanais
);

CREATE TABLE Comodos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100)
);

CREATE TABLE DispositivosAlexa (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT,
    nome VARCHAR(100),
    token_api VARCHAR(255),
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id)
);

CREATE TABLE Cameras (
    id INT AUTO_INCREMENT PRIMARY KEY,
    comodo_id INT,
    ip_stream VARCHAR(100),
    status ENUM('ativa', 'inativa') DEFAULT 'ativa',
    FOREIGN KEY (comodo_id)
        REFERENCES Comodos (id)
);

CREATE TABLE Luzes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
    comodo_id INT,
    intensidade INT, -- 0 a 100%
    status ENUM('ligada', 'desligada'),
    FOREIGN KEY (comodo_id) REFERENCES Comodos(id)
);

CREATE TABLE ConsumoSemanal (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT,
    semana_inicio DATE,
    semana_fim DATE,
    consumo_agua_litros DECIMAL(10,2),
    consumo_energia_kwh DECIMAL(10,2),
    gasto_total DECIMAL(10,2),
    economia_energia_kwh DECIMAL(10,2), -- comparado à média histórica
    pontos_gerados INT DEFAULT 0,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id)
);

CREATE TABLE Contas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT,
    mes_referencia DATE,
    valor_base DECIMAL(10,2),
    desconto DECIMAL(10,2),
    valor_final DECIMAL(10,2),
    status_pagamento ENUM('pago', 'pendente') DEFAULT 'pendente',
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id)
);

CREATE TABLE RegrasEconomia (
    id INT AUTO_INCREMENT PRIMARY KEY,
    descricao TEXT,
    economia_min_kwh DECIMAL(10,2),
    pontos_bonus INT
);

-- Procedure de cálculo de pontos

DROP PROCEDURE IF EXISTS CalcularPontosEconomia;
DELIMITER $$

CREATE PROCEDURE CalcularPontosEconomia()
BEGIN
    DECLARE done INT DEFAULT FALSE;
    DECLARE v_usuario_id INT;
    DECLARE v_consumo_atual DECIMAL(10,2);
    DECLARE v_media_anterior DECIMAL(10,2);
    DECLARE v_economia DECIMAL(10,2);
    DECLARE v_pontos INT;

    DECLARE cur CURSOR FOR
        SELECT usuario_id, consumo_energia_kwh
        FROM ConsumoSemanal
        WHERE semana_fim = (SELECT MAX(semana_fim) FROM ConsumoSemanal);

    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;

    OPEN cur;

    loop_calc: LOOP
        FETCH cur INTO v_usuario_id, v_consumo_atual;
        IF done THEN
            LEAVE loop_calc;
        END IF;

        -- Calcula a média das 4 semanas anteriores
        SELECT AVG(consumo_energia_kwh) INTO v_media_anterior
        FROM ConsumoSemanal
        WHERE usuario_id = v_usuario_id
        AND semana_fim < (SELECT MAX(semana_fim) FROM ConsumoSemanal)
        ORDER BY semana_fim DESC
        LIMIT 4;

        SET v_economia = v_media_anterior - v_consumo_atual;

        IF v_economia > 0 THEN
            SET v_pontos = FLOOR((v_economia / v_media_anterior) * 100);
            IF v_pontos > 100 THEN
                SET v_pontos = 100;
            END IF;
        ELSE
            SET v_pontos = 0;
        END IF;

        -- Atualiza pontos da semana
        UPDATE ConsumoSemanal
        SET pontos_gerados = v_pontos
        WHERE usuario_id = v_usuario_id
        AND semana_fim = (SELECT MAX(semana_fim) FROM ConsumoSemanal);

        -- Acumula pontos no total do usuário
        UPDATE Usuarios
        SET pontos = pontos + v_pontos
        WHERE id = v_usuario_id;
    END LOOP;

    CLOSE cur;
END$$

DELIMITER ;

