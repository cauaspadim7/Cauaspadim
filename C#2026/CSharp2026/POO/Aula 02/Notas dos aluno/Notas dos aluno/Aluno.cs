namespace Notas_do_aluno
{
    internal class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;


        public double NotaFinal()
        {
            double NotaFinal = nota1 + nota2 + nota3;
            return NotaFinal;
        }

        public bool AprovadoOuReprovado()
        {
            bool AprovadoOuReprovado = NotaFinal() < 60;
            return AprovadoOuReprovado;
        }


        public double QuantoFaltou()
        {
            double QuantoFaltou = NotaFinal() - 60;
            return QuantoFaltou;
        }


    }

}
