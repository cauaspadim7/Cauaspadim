namespace ProjetoWeb01.Classes.Entidades
{
    public class Cursos
    {
        private Dictionary<int, string> cursos = new Dictionary<int, string>()
        {
            { 1 , "Desenvolvedor Backend" },
            {2 , "Técnico em eletrônica" },
            {3 , "Mecânico de manutenção" }

        };

        //propfull

         public Dictionary<int, string> Curso
        {
            get { return cursos; }
            set { cursos = value; }
        }

    }
}
