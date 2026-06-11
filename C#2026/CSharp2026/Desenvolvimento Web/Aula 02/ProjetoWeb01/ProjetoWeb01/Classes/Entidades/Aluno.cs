using ProjetoWeb01.Classes.Enumeracoes;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoWeb01.Classes.Entidades
{
    public class Aluno : Usuario
    {
        public int RA { get; set; }

        public string StatusWIFI { get; set; } = "Inativo";

        public string StatusAction { get; set; } = "Aguardando Aprovação";

        public int CursoID { get; set; }

        // Construtor para garantir que Regra sempre tenha um valor padrão
        public Aluno()
        {
            Regra = TipoRegra.Usuario;
            Email = Email ?? string.Empty;
            Senha = Senha ?? string.Empty;
        }
    }
}