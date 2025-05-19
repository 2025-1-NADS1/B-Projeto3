using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  // <- esse aqui conecta com o MySQL

public partial class Form1 : Form
{
    // Sua connection string
    string connectionString = "server=localhost;port=3306;user=root;password=;database=banco_de_dados;";


    private void CarregarUsuarios()
    {
        using (MySqlConnection conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();
            string query = "SELECT nome, email, tipo, pontos FROM Usuarios";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            using (MySqlDataReader reader = comando.ExecuteReader())
            {
                string resultado = "";

                while (reader.Read())
                {
                    resultado += $"Nome: {reader["nome"]}\n";
                    resultado += $"Email: {reader["email"]}\n";
                    resultado += $"Tipo: {reader["tipo"]}\n";
                    resultado += $"Pontos: {reader["pontos"]}\n\n";
                }

                MessageBox.Show(resultado == "" ? "Nenhum usuário encontrado." : resultado, "Usuários");
            }
        }
    }
}
    

namespace Pi
{
    public partial class menurestrito : Form
    {
        string connectionString = "server=localhost;port=3306;user=root;password=;database=banco_de_dados;";

        public menurestrito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var recompensa = new gamefication();
            recompensa.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e) //picture para voltar
        {
            var voltar = new login();
            voltar.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            var recompensa = new gamefication();
            recompensa.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var bill = new conta();
            bill.Show();
            this.Visible = false;
        }
    }
}
