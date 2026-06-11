using ProjetoWeb01.Dados;
using ProjetoWeb01.Classes.Entidades;
using ProjetoWeb01.Classes.Enumeracoes;
using Microsoft.EntityFrameworkCore;

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

                // Verifica se já existe aluno com o mesmo RA
                if (await dbContext.Alunos.AnyAsync(a => a.RA == aluno.RA))
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Já existe um aluno cadastrado com este RA."
                    };
                }

                //Definir os status padrão pra novos cadastros
                aluno.StatusWIFI = "Inativo";
                aluno.StatusAction = "Aguardando aprovação";

                if (string.IsNullOrWhiteSpace(aluno.Email))
                {
                    aluno.Email = $"ra{aluno.RA}@aluno.local";
                }

                if (string.IsNullOrWhiteSpace(aluno.Senha))
                {
                    aluno.Senha = aluno.RA.ToString();
                }

                // Garantir que Regra tenha um valor válido
                aluno.Regra = TipoRegra.Usuario;

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
                // Inclui detalhes da inner exception para auxiliar no diagnóstico
                var detalhe = ex.InnerException?.Message ?? ex.Message;
                return new ResultadoCadastro
                {
                    Sucesso = false,
                    Mensagem = $"Erro ao cadastrar o aluno: {detalhe}"
                };
            }
        }
    }
}