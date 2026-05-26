using ProjetoWeb01.Classes.Enumeracoes;

namespace ProjetoWeb01.Classes.Entidades
{
    public class Aluno : Usuario
    {
        public int RA { get; set; }

        public string StatusWIFI { get; set; } = "Inativo";

        public string StatusAction { get; set; } = "Aguardando aprovação";
        public Cursos CursoID { get; set; }

        public TipoRegra TipoRegra { get; set; } = TipoRegra.Usuario;
    }
}
