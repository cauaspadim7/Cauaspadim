namespace Banco
{
    internal class ContaBancaria
    {
        //Campos ou atributos
        private int numero;
        private string titular;
        private double saldo;

        //Construtor
        public ContaBancaria(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            this.saldo = saldo;
        }

        //Métodos
        public void Deposito(double quantia)
        {
            saldo += quantia;
        }

        public void Saque(double quantia)
        {
            saldo -= quantia;
        }

        public void Dados()
        {
            Console.WriteLine($"Dados da conta cadastrada: ");
            Console.WriteLine($"\tTitula: {titular}\n" +
                $"\tNumero da conta: {numero}\n" +
                $"\tSaldo da conta: R$ {saldo}");
        }
    }
}