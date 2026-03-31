
namespace Banco_Master
{
    internal class ContaPoupança : Conta
    {
        private double taxaDeJuros;
      

        public double Juros
        {
            get { return Juros; }
            set { Juros = value; }
        }
        public void AtualizaçoesDesaldo()
        {
            SaldoConta += SaldoConta * taxaDeJuros;
        }


        public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }  
       
    }
}
