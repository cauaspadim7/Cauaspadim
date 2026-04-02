using Banco_Master;

namespace BancoMaster
{
    internal class ContaEmpresa : Conta
    {
        //Campo
        private double limite;


        //Propriedade
        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        //Construtor
        public ContaEmpresa(int numeroConta, string titularConta, double limite) : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = limite;
        }

        public ContaEmpresa(int numeroConta, string titularConta, double saldoConta, double limite) : base(numeroConta, titularConta, saldoConta)
        {
            LimiteEmprestimo = limite;
        }

        //Método
        public void Emprestimo(double qtd)
        {
            LimiteEmprestimo -= qtd;
            SaldoConta += qtd;
        }

    }
}
