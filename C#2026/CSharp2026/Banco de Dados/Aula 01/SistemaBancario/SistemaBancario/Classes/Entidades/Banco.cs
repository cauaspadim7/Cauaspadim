
namespace SistemaBancario.Classes.Entidades
{
    /// <summary>
    ///  Classe que representa uma conta bancaria com operaçoes básicas
    ///  Implementa as regras de negocio
    /// </summary>
    internal class Banco
    {
        //Campo
        /// <summary>
        /// Taxa fixa cobrada em cada operação de saque
        /// </summary>

        private const double TaxaSaque = 5.00;

        //Propriedades
        /// <summary>
        /// Identificador unico da conta bancaria no banco de dados (gerado automaticamento)
        /// </summary>

        public int Id { get; set; }

        ///<summary>
        ///Numero da conta bancaria
        ///'init' garante que o valor só pode ser atribuido na criação(imutável após construção)
        /// </summary>

        public int NumeroConta { get; init; }

        ///<summary>
        ///Nome do titular da conta
        ///</summary>


        public string Titular { get; set; }

        ///<summary>
        ///Saldo atual a conta
        ///'private set' impede alteraçao direta - só pode mudar através de Deposito ou Saque
        /// </summary>
        public double Saldo { get; private set; }

        //Construtores
        /// <summary>
        /// Construtor privado sem parametros
        /// Necessarios p/ o Entity Framework instancia a classe ao buscar no banco de dados
        /// Não deve ser utilizado diretamente no codigo
        /// </summary>

        private Banco()
        {

        }
        /// <summary>
        /// Construtor principal para criar uma nova conta bancaria
        /// </summary>
        /// <param name="numeroConta">Número unico da conta (não pode ser alterado depois)</param>
        /// <param name="titular">Nome do titular da conta</param>
        /// <param name="saldo">Valor do deposito inicial (opcional, padrao = 0)</param>



        public Banco(int numeroConta, string titular, double saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        //Métodos
        /// <summary>
        ///Realiza um deposito na conta, aumentando o saldo
        /// </summary>
        /// <param name="valor">Valor a ser depositado</param>
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }
        //Metodos
        /// <summary>
        ///Realiza um deposito na conta, aumentando o saldo
        /// <summary>
        /// <param name="valor">Valor a ser depositado, dever ser positivo<param>
        public void Deposito(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor de deposito deve ser positivo");
                return;
            }

            Saldo += valor;

            Console.WriteLine($"Deposito de {valor:C} realizado com sucesso!!!!");
        }
        ///<summary> Realiza um saque na conta, diminuindo o saldo
        ///Cobra automaticamente uma taxa de R$5,00 por cada saque
        ///IMPORTANTE: Permite saldo negativo se nao houver fundos.
        ///</summary>
        /// <summary> 
        /// <param name="valor">Valor a ser sacado, deve ser positivo , nao inclui a taxa de saque</param>

        public void Saque(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor de saque deve ser positivo");
                return;
            }
            Saldo -= valorTotal;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso! Taxa de saque: {TaxaSaque:C}. Saldo atual: {Saldo:C}");
        }
    }
}   


