
namespace Banco_Master
{
    internal class ContaPoupança : Conta
    {
        private double taxaDeJuros;

        public double TaxaDeJuros
        {
            get { return taxaDeJuros; }
            set { taxaDeJuros = value; }
        }

        public ContaPoupança(int numeroConta, string titularConta, double saldoConta, double taxaDeJuros)
            : base(numeroConta, titularConta, saldoConta)
        {
            this.taxaDeJuros = taxaDeJuros;
        }

        public ContaPoupança(int numeroConta, string titularConta, double taxaDeJuros)
            : base(numeroConta, titularConta)
        {
            this.taxaDeJuros = taxaDeJuros;
        }

        public void AtualizacaoDeSaldo()
        {
            SaldoConta += SaldoConta * taxaDeJuros;
        }

        public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }
    }
}
