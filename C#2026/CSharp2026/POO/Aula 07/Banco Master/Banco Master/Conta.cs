using Banco_Master;

namespace Banco_Master
{
    internal class Conta
    {
        //Campo

        private int numero;
        private string titular;
        private double saldo;


        //Propriedades


        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }


        public string TitularConta
        {
            get { return titular; }
            set { titular = value; }
        }

        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //Construtor


        public Conta(int numeroConta, string titularConta, double saldoConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
        }

        public Conta(int numeroConta, string titularConta) : this(numeroConta, titularConta, 0)
        {
            SaldoConta = 0;
        }

        //Metodos

        public void Saque(double quantia)
        {
            SaldoConta -= quantia + 5.00;
        }

        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }
     
    }
}