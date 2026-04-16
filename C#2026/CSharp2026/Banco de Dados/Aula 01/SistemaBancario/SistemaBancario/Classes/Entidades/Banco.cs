namespace SistemaBancario.Classes.Entidades
{
    /// <summary>
    /// Classe que representa uma conta bancária com operações básicas
    /// Implementa as regras de negócio
    /// </summary>
    internal class Banco
    {
        //Campo
        ///<summary>
        /// Taxa fixa cobrada em cada operação de saque
        /// </summary>
        private const decimal taxaSaque = 5.00m;


        //Propriedades
        ///<summary>
        /// Identificador único da conta bancária no banco de dados (gerado automaticamente)
        /// </summary>
        public int Id { get; set; }

        ///<summary>
        ///Numero da conta bancaria
        ///'init' garante que o valor só pode ser atribuido na criação(imutável após construção)
        /// </summary>
        public int NumeroConta { get; init; }

        ///<summary>
        ///Nome do titular da conta
        /// </summary>

        public string Titular { get; set; }

        ///<summary>
        ///Saldo atual da conta
        ///'private set' impede alteração direta - só pode mudar através de Deposito ou Saque
        /// </summary>
        public decimal Saldo { get; private set; }

        //Construtores
        /// <summary>
        /// Construtor privado sem parâmetros
        /// Necessário p/ o Entity Framework instanciar a classe ao buscar no banco de dados
        /// Não deve ser utilizado diretamente no código
        /// </summary>
        private Banco()
        {
        }
        /// <summary>
        /// Construtor principal para criar uma nova conta bancária
        /// </summary>
        /// <param name="numeroConta">Número único da conta (não pode ser alterado depois)</param>
        /// <param name="titular">Nome do titular da conta</param>
        /// <param name="saldo">Valor do depósito inicial (opcional, padrão = 0)</param>
        public Banco(int numeroConta, string titular, decimal saldo = 0)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        //Métodos
        ///<summary>
        ///Realiza um depósito na conta, aumentando o saldo da conta.
        /// </summary>
        /// <param name="valor">Valor a ser depositado, deve ser positivo</param>
        ///
        public void Deposito(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito deve ser positivo");
                return;
            }

            Saldo += valor;

            Console.WriteLine($"Depósito de {valor:C} realizado com sucessooooo!!!!");
        }

        ///<summary>
        ///Realiza um saque na conta, diminuindo o saldo
        ///Cobra automaticamente uma taxa de R$5.00 por saque.
        ///IMPORTANTE: Permite saldo negativo se não houver fundos.
        /// </summary>
        /// <param name="valor">Valor a ser sacado(deve ser positivo, não inclui a taxa)</param>
        public void Saque(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque deve ser positivo");
                return;
            }

            Saldo -= (valor + taxaSaque);
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso! Taxa de {taxaSaque:C} cobrada.");
        }

        ///<summary>
        ///Exibe os dados da conta no console
        ///Mostra número da conta, titular e saldo atual
        /// </summary>
        ///
        public void ExibirDados()
        {
            Console.WriteLine("\n---Dados da conta---");
            Console.WriteLine($"Conta: {NumeroConta}");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: {Saldo:C}");
            Console.WriteLine("--------------------\n");
        }
    }
}


