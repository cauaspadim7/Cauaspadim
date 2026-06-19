


using AplicativoDesktop01.Classes.DTO;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace AplicativoDesktop01
{
    public partial class TelaLogin : Form
    {
        private static readonly HttpClient clienteHttp = new();
        private const string urlApiLogin = "http://localhost:5085/api/usuarios/login";
    
public TelaLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var dadosLogin = new LoginRequestDTO
            {
                Email = textBox1.Text.Trim(),
                Senha = textBox2.Text.Trim(),
            };

            try
            {
                var resposta = await clienteHttp.PostAsJsonAsync(urlApiLogin, dadosLogin);

                if (resposta.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                    return;
                }

                else if (!resposta.IsSuccessStatusCode)
                {
                    var mensagemErro = await resposta.Content.ReadAsStringAsync();
                    MessageBox.Show($"Não foi possível autenticar. Detalhes {mensagemErro}");
                    return;
                }

                var resultado = await resposta.Content.ReadFromJsonAsync<LoginResponseDTO>();

                if (resultado.Regra != 1)
                {
                    MessageBox.Show("Acesso Negado. Este usuario não tem privilégios administrativo");
                    return;
                }

                MessageBox.Show("Login realizado com sucesso");
                this.Hide();
                using (var telaAdmin = new TelaAdmin())
                {
                    telaAdmin.ShowDialog();
                }
                this.Close();

            }

            catch (HttpRequestException)
            {
                MessageBox.Show("Não foi possivel conectar na API");
            }
        }

    }
}