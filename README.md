```sh
Utilize o site <https://www.toptal.com/developers/gitignore> para gerar seu arquivo gitignore e apague este campo.

Vide tutoriais do PI.
```

# FECAP - Fundação de Comércio Álvares Penteado

<p align="center">
<a href= "https://www.fecap.br/"><img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhZPrRa89Kma0ZZogxm0pi-tCn_TLKeHGVxywp-LXAFGR3B1DPouAJYHgKZGV0XTEf4AE&usqp=CAU" alt="FECAP - Fundação de Comércio Álvares Penteado" border="0"></a>
</p>

# Nome do Projeto 

## Nome do Grupo: Solucoders

## Integrantes: Guilherme Gomes Salvadeo, Arthur Garutti, Pedro Henrique Aráujo Del Picolo


## Professores Orientadores: <a href="https://www.linkedin.com/in/victorbarq/">Dr. Victor Von Doom</a>, <a href="https://www.linkedin.com/in/victorbarq/">Me. Saitama</a>, <a href="https://www.linkedin.com/in/victorbarq/">Dr. Strange</a>, <a href="https://www.linkedin.com/in/victorbarq/">Me. Yoda</a>, <a href="https://www.linkedin.com/in/victorbarq/">Dr. Gero</a>

## Descrição

<p align="center">
<img src="https://pix4free.org/assets/library/2021-01-20/originals/game.jpg" alt="NOME DO JOGO" border="0">
  Game by <a href="http://www.nyphotographic.com/">Nick Youngson</a> <a rel="license" href="https://creativecommons.org/licenses/by-sa/3.0/">CC BY-SA 3.0</a> <a href="http://pix4free.org/">Pix4free</a>
</p>


Este projeto tem como principal objetivo conscientizar os usuários sobre o consumo de energia elétrica e água em uma residência automatizada — uma smart house. Em um contexto onde a sustentabilidade é cada vez mais essencial, buscamos mostrar que pequenas ações conscientes no dia a dia podem gerar grandes impactos no futuro.

A aplicação foi desenvolvida com foco em educação ambiental, integrando tecnologia, automação e visualização de dados para promover a mudança de comportamento dos moradores da casa em relação ao uso de recursos naturais.
<br><br>
O sistema monitora o consumo de energia elétrica e água e apresenta esses dados de forma visual e acessível, por meio de gráficos e tabelas atualizadas semanalmente. Isso permite ao usuário acompanhar seu histórico de uso, identificar padrões e refletir sobre hábitos que podem ser melhorados.

Além do monitoramento, o projeto inclui um sistema de recompensas: quanto mais o usuário economiza, mais recompensas simbólicas ele recebe. Esse recurso gamificado incentiva a economia de forma positiva, tornando a experiência mais interativa e motivadora.
<br><br>


## 🛠 Estrutura de pastas

-Raiz<br>
|<br>
|-->documentos<br>
  &emsp;|-->antigos<br>
  &emsp;|Documentação.docx<br>
|-->executáveis<br>
  &emsp;|-->windows<br>
  &emsp;|-->android<br>
  &emsp;|-->HTML<br>
|-->imagens<br>
|-->src<br>
  &emsp;|-->Backend<br>
  &emsp;|-->Frontend<br>
|readme.md<br>

A pasta raiz contem dois arquivos que devem ser alterados:

<b>README.MD</b>: Arquivo que serve como guia e explicação geral sobre seu projeto. O mesmo que você está lendo agora.

Há também 4 pastas que seguem da seguinte forma:

<b>documentos</b>: Toda a documentação estará nesta pasta.

<b>executáveis</b>: Binários e executáveis do projeto devem estar nesta pasta.

<b>imagens</b>: Imagens do sistema

<b>src</b>: Pasta que contém o código fonte.

## 🛠 Instalação

<b>Android:</b>

Faça o Download do JOGO.apk no seu celular.
Execute o APK e siga as instruções de seu telefone.

```sh
Coloque código do prompt de comnando se for necessário
```

<b>Windows:</b>

Não há instalação! Apenas executável!
Encontre o JOGO.exe na pasta executáveis e execute-o como qualquer outro programa.

```sh
Coloque código do prompt de comnando se for necessário
```

<b>HTML:</b>

Não há instalação!
Encontre o index.html na pasta executáveis e execute-o como uma página WEB (através de algum browser).

## 💻 Configuração para Desenvolvimento

Descreva como instalar todas as dependências para desenvolvimento e como rodar um test-suite automatizado de algum tipo. Se necessário, faça isso para múltiplas plataformas.

Para abrir este projeto você necessita das seguintes ferramentas:

-<a href="https://godotengine.org/download">GODOT</a>

```sh
make install
npm test
Coloque código do prompt de comnando se for necessário
```

## 📋 Licença/License
Utilize o link <https://chooser-beta.creativecommons.org/> para fazer uma licença CC BY 4.0.


## 🎓 Entrega Disciplina Entrega Disciplina
Fundamentos de Bancos de Dados
Segunda Entrega
....
📋 Documentação das Tabelas – Sistema de Casa Inteligente
🏠 CASA
Essa tabela guarda as informações principais sobre cada residência cadastrada no sistema.

id_casa (int): Identificador único da casa.

nome (varchar 100): Nome dado à casa (ex: "Casa da Praia", "Apartamento 202").

endereco (varchar 255): Endereço completo da casa.

Campo (int): Campo adicional (pode ser usado para funcionalidades extras ou futuras integrações).

🛋️ COMODOS
Aqui ficam os dados dos cômodos de cada casa, como quartos, salas, banheiros etc.

id_comodo (int): Identificador único do cômodo.

nome (varchar 100): Nome do cômodo (ex: "Sala de Estar", "Cozinha").

tipo (varchar 50): Tipo do cômodo (ex: quarto, banheiro).

id_casa (int): Referência de qual casa esse cômodo faz parte.

Campo (int): Campo adicional para uso futuro ou auxiliar.

💡 Uma casa pode ter vários cômodos, mas cada cômodo pertence a apenas uma casa.

📱 DISPOSITIVOS
Essa tabela armazena todos os dispositivos inteligentes que você instalou (como lâmpadas, câmeras, sensores, etc).

nome (varchar): Nome do dispositivo.

tipo (varchar 200): Tipo do dispositivo (ex: "Lâmpada", "Sensor de Movimento").

status (varchar 50): Estado atual (ex: "ligado", "desligado").

id_comodo (int): Em qual cômodo esse dispositivo está.

id_disp (int): Identificador único do dispositivo.

Campo (int): Campo extra para controle ou funcionalidades adicionais.

⚙️ AUTOMACAO
Define as automações configuradas no sistema, ou seja, as regras para que algo aconteça automaticamente.

nome (varchar 100): Nome da automação (ex: "Ligar luz ao anoitecer").

acao (varchar 255): Ação que será realizada (ex: "ligar luz").

condicao (varchar 255): Condição que ativa a ação (ex: "se hora for 18h").

id_auto (int): Identificador único da automação.

id_dispositivo (int): Qual dispositivo será afetado.

Campo (int): Campo adicional, caso precise de mais controle.

🔗 Relacionamentos
Uma casa pode ter vários cômodos.

Cada cômodo pode ter vários dispositivos.

Um dispositivo pode ser controlado por várias automações e vice-versa.

Automações também podem se relacionar a cômodos dependendo da lógica do sistema.




## 🎓 Referências

Aqui estão as referências usadas no projeto.

1. <https://github.com/iuricode/readme-template>
2. <https://github.com/gabrieldejesus/readme-model>
3. <https://chooser-beta.creativecommons.org/>
4. <https://freesound.org/>
5. <https://www.toptal.com/developers/gitignore>
6. Músicas por: <a href="https://freesound.org/people/DaveJf/sounds/616544/"> DaveJf </a> e <a href="https://freesound.org/people/DRFX/sounds/338986/"> DRFX </a> ambas com Licença CC 0.
