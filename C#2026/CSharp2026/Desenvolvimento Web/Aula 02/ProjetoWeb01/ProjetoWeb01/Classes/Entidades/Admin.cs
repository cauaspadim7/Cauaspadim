using ProjetoWeb01.Classes.Enumeracoes;

namespace ProjetoWeb01.Classes.Entidades
{
    public class Admin : Usuario
    {
        public TipoRegra TipoRegra { get; set; } = TipoRegra.Admin;
    }
}
