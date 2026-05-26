using ProjetoWeb01.Classes.Enumeracoes;

namespace ProjetoWeb01.Classes.Entidades
{
    public class Usuario
    {
        //ID, Nome, Email, Senha, Regras

        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoRegra Regra { get; set; }
    }
}
