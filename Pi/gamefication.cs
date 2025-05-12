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
            try
            {
                // Pega o texto da TextBox e separa os valores por vírgula
                string[] partes = txtNota1.Text.Split(',');

                // Verifica se foram digitados exatamente 3 valores
                if (partes.Length != 10)
                {

                }

                // Converte os valores para double e remove espaços extras
                double valor1 = double.Parse(partes[0].Trim());
                double valor2 = double.Parse(partes[1].Trim());
                double valor3 = double.Parse(partes[2].Trim());

                // Calcula a média
                double media = (valor1 + valor2 + valor3) / 3;

                // Exibe a média no Label
                lblResultado.Text = "Média: " + media.ToString("F2");

                if (media >= 110)
                {
                    MessageBox.Show("Parabéns, você ganhou 10 pontos de experiência!");
                }
            }
            catch
            {

            }


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
    }
}
