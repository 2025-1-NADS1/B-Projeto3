using System;
using System.Data;
using System.Windows.Forms;

namespace CasaInteligentePI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Criar a tabela
            DataTable tabela = new DataTable();
            tabela.Columns.Add("C�modo");
            tabela.Columns.Add("Sensor");
            tabela.Columns.Add("Status");

            // Linhas simuladas
            tabela.Rows.Add("Sala", "Luz", "Ligado");
            tabela.Rows.Add("Sala", "Temperatura", "Desligado");
            tabela.Rows.Add("Cozinha", "G�s", "Ligado");
            tabela.Rows.Add("Quarto", "Presen�a", "Desligado");

            tabelaSensores.DataSource = tabela;

            // Adiciona coluna com bot�o
            if (!tabelaSensores.Columns.Contains("A��o"))
            {
                DataGridViewButtonColumn botao = new DataGridViewButtonColumn();
                botao.HeaderText = "A��o";
                botao.Name = "btnAcao";
                botao.Text = "Alternar";
                botao.UseColumnTextForButtonValue = true;
                tabelaSensores.Columns.Add(botao);
            }
        }

        private void tabelaSensores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que � a coluna de bot�o e uma linha v�lida
            if (e.ColumnIndex == tabelaSensores.Columns["btnAcao"].Index && e.RowIndex >= 0)
            {
                var linha = tabelaSensores.Rows[e.RowIndex];
                var status = linha.Cells["Status"].Value?.ToString();

                if (status == "Ligado")
                    linha.Cells["Status"].Value = "Desligado";
                else
                    linha.Cells["Status"].Value = "Ligado";
            }
        }
    }
}
