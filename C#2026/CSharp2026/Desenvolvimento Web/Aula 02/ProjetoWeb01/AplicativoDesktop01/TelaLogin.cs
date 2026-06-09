namespace AplicativoDesktop01
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "Ronaldo";
            string senha = "123456";

            bool comparacao1 = textBox1.Text == usuario;
            bool comparacao2 = textBox2.Text == senha;

            if (comparacao1 && comparacao2)
            {
                MessageBox.Show("Usuario e senha corretos!");
                this.Hide();
                using (var telaAdm = new TelaAdmin())
                {
                    telaAdm.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou senhas incorretos!");
            }
        }

        private void CX(object sender, EventArgs e)
        {

        }
    }
}