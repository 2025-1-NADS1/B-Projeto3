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
            tabela.Columns.Add("Cômodo");
            tabela.Columns.Add("Sensor");
            tabela.Columns.Add("Status");

            // Linhas simuladas
            tabela.Rows.Add("Sala", "Luz", "Ligado");
            tabela.Rows.Add("Sala", "Temperatura", "Desligado");
            tabela.Rows.Add("Cozinha", "Gás", "Ligado");
            tabela.Rows.Add("Quarto", "Presença", "Desligado");

            tabelaSensores.DataSource = tabela;

            // Adiciona coluna com botão
            if (!tabelaSensores.Columns.Contains("Ação"))
            {
                DataGridViewButtonColumn botao = new DataGridViewButtonColumn();
                botao.HeaderText = "Ação";
                botao.Name = "btnAcao";
                botao.Text = "Alternar";
                botao.UseColumnTextForButtonValue = true;
                tabelaSensores.Columns.Add(botao);
            }
        }

        private void tabelaSensores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que é a coluna de botão e uma linha válida
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
