using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pi
{
    public partial class gamefication : Form
    {
        public gamefication()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var menu = new menurestrito();
            menu.Show();
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Pega o texto da TextBox e separa por vírgula
                    string[] partes = txtNota1.Text.Split(',');

                    // Verifica se tem exatamente 3 valores
                    if (partes.Length != 3)
                    {
                        MessageBox.Show("Digite exatamente 3 números separados por vírgula.");
                        return;
                    }

                    // Converte para double
                    double valor1 = double.Parse(partes[0].Trim());
                    double valor2 = double.Parse(partes[1].Trim());
                    double valor3 = double.Parse(partes[2].Trim());

                    // Calcula a média
                    double media = (valor1 + valor2 + valor3) / 3;

                    // Mostra a média
                    lblResultado.Text = "Média: " + media.ToString("F2");

                    // Exibe a mensagem de acordo com a média
                    if (media <= 99)
                    {
                        MessageBox.Show("Parabéns, você ganhou 100 pontos de experiência! Você tem o selo de amigo do meio ambiente");
                    }
                    else if (media >= 100 && media <= 149)
                    {
                        MessageBox.Show("Parabéns, você ganhou 80 pontos de experiência! Você pode fazer melhor");
                    }
                    else if (media >= 150 && media <= 249)
                    {
                        MessageBox.Show("Parabéns, você ganhou 60 pontos de experiência! Você está na média mas pode melhorar sua economia");
                    }
                    else if (media >= 250 && media <= 399)
                    {
                        MessageBox.Show("Parabéns, você ganhou 20 pontos de experiência! Você está acima da média, mude seus hábitos enquanto há tempo");
                    }
                    else
                    {
                        MessageBox.Show("Você está consumindo muita energia. Mude seus hábitos imediatamente");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Entrada inválida. Digite apenas números separados por vírgula, como: 100,150,200");
                }
            }
        }
    }
}
