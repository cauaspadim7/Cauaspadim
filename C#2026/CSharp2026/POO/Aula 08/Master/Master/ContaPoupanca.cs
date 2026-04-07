

namespace Master
{
    internal class ContaPoupanca : Conta
    {
		// Campo

		private double rendimento;


        //Propiedades

        public double RendimentoConta
		{
			get { return rendimento; }
			set { rendimento = value; }
		}
		//Construtor
        public ContaPoupanca(int numeroConta, double saldoConta, Pessoa dadosCliente, double rendimento) : base(numeroConta, saldoConta, dadosCliente)
        {
		    RendimentoConta = rendimento;
        }


		//Métodos
		public void Consulta()
		{
			Console.WriteLine($"Dados do cliente:\n" +
				$"\t Nome: {DadosCliente.nome}\n" +
				$"\t CPF: {DadosCliente.cpf}\n" +
				$"\t Numero:{NumeroConta}\n" +
				$"\t Saldo: {SaldoConta}\n" +
			    $"\t Rendimento: {rendimento}%");


        }

	}
}
