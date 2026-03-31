namespace Heranca
{
    internal class PessoaJuridica : PessoaFissica
    {

        //Campos

        private double limite;

        //Propiedades

        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        //Construtoes

        public PessoaJuridica(int numeroConta, string titularConta, double limiteConta)
            : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        public PessoaJuridica(int numeroConta, string titularConta, double saldoConta, double limiteConta)
            : base(numeroConta, titularConta, saldoConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        //Metodos
        public void Limite(double quantia)
        {
            SaldoConta += quantia;
        }
    }
}