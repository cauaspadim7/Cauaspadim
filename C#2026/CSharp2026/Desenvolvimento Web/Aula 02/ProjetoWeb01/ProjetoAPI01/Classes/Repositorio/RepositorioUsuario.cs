using ProjetoAPI01.Classes.DTO;
using Microsoft.Data.SqlClient;


namespace ProjetoAPI01.Classes.Repositorio
{

    public class RepositorioUsuario
    {

        private readonly string stringConexao;

        public RepositorioUsuario(string conexao)
        {
            this.stringConexao = conexao;
        }

        // Método para consulta do usuário por email e senha, retorna somente dados necessários para o login
        public async Task<UsuarioDTO?> BuscarPorEmailSenha(string email, string senha, CancellationToken cancellationToken)

        {
            await using var conexao = new SqlConnection(stringConexao);
            await conexao.OpenAsync(cancellationToken);

            const string comandoSql = """
                SELECT TOP 1 Id, Nome, Regra 
                FROM Alunos
                WHERE Email = @Email AND Senha = @Senha;
                """;
            await using var comando = new SqlCommand(comandoSql, conexao);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Senha", senha);

            await using var leitor = await comando.ExecuteReaderAsync(cancellationToken);
            if (!await leitor.ReadAsync(cancellationToken))
            {
                return null;
            }

            return new UsuarioDTO
            {
                Id = leitor.GetInt32(leitor.GetOrdinal("Id")),
                Nome = leitor.GetString(leitor.GetOrdinal("Nome")),
                Regra = leitor.GetInt32(leitor.GetOrdinal("Regra"))
            };
        }
    }
}
