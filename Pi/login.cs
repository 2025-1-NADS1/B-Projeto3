namespace Pi
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = textBox1.Text; //pega o texto do textBox1
            
            String senha = textBox2.Text;   //pega o texto do textBox2
            
            if (usuario == "admin" && senha == "1234") //atribui valores as variaveis e quando correto o valor da acesso a próxima pagina
            {
                MessageBox.Show("Login bem-sucedido!"); //mostra login bem-sucedido
               
                var menu = new menurestrito(); //cria uma nova instancia do menu restrito
                
                menu.Show(); //mostra o menu restrito

                this.Visible = false; //esconde a tela de login
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }
    }
}
