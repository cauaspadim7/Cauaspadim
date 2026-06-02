using ProjetoWeb01.Dados;
using ProjetoWeb01.Classes.Entidades;

namespace ProjetoWeb01.Classes.Serv
{
    public class AlunoService
    {
        //Campo
        private readonly AlunoContext dbContext;

        //Construtor
        public AlunoService(AlunoContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Tarefa
        public async Task<ResultadoCadastro> CadastrarAluno(Aluno aluno)
        {
            try
            {
                //Validação básica de cadastro
                if (string.IsNullOrWhiteSpace(aluno.Nome))
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor, informe o nome válido de aluno"
                    };
                }

                if (aluno.RA <= 0)
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor, informe um RA válido"
                    };
                }
                if (aluno.CursoID <= 0)
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor, selecione um curso"
                    };
                }
                //Definir os status padrao para novos cadastros
                aluno.StatusWIFI = "Inativo";
                aluno.StatusAction = "Aguardando aprovação";
                //Adicionar o aluno ao banco de dados
                dbContext.Alunos.Add(aluno);
                await dbContext.SaveChangesAsync();

                return new ResultadoCadastro
                {
                    Sucesso = true,
                    Mensagem = "Aluno cadastrado com sucesso!"
                };

            }
            catch (Exception ex)
            {
                return new ResultadoCadastro
                {
                    Sucesso = false,
                    Mensagem = $"erro ao cadastrar o aluno: {ex.Message}"
                };
            }
        }
    }
}
