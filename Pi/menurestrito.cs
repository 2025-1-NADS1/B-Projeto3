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
    public partial class menurestrito : Form
    {
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
    }
}
