using System;
using System.Net.Http.Headers;

namespace Banco1
{
    internal class ContaBancaria
    {
        // Campos 
        private int numero;
        private string titular;
        private double saldo;

        // Propriedades
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value > 0)
                {
                    saldo = value;
                }
                else
                {
                    saldo = 0;
                }
            }

           
        }

        // Construtores
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double saldo)
            : this(numero, titular)
        {
            Saldo = saldo;
        }

      
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }
        public void Dados()
        {
            Console.Write($"Dados da conta: \n" +
                $"\tConta: {Numero}\n" +
                $"\tTitular: {Titular}\n" +
                $"\tSaldo: R$ {Saldo:C}");
        }
    }
}