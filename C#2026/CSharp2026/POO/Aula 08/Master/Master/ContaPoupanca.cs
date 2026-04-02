

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
        public ContaPoupanca(int numeroConta, double saldoConta, Pessoa dadosCliente, double Rendimento) : base(numeroConta, saldoConta, dadosCliente)
        {
		    RendimentoConta = rendimento;
        }


		//Métodos
		public void Consulta()
		{
			Console.WriteLine($"Dados do cliente:\n" +
				$"\t Nome: {DadosCliente}\n" +
				$"\t Numero: {NumeroConta}\n" +
				$"\t Saldo: {SaldoConta}");


		}

	}
}
