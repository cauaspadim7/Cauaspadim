
namespace Master
{
    internal class ContaPJ : Conta
    {
		//Campo

		private double limite;


        //Propiedades

        public  double LimiteConta
		{
			get { return limite; }
			set { limite = value; }
		}
        //Construtor
        public ContaPJ(int numeroConta, double saldoConta, Pessoa dadosCliente, double limite) : base(numeroConta, saldoConta, dadosCliente)
        {
            LimiteConta = limite;
        }


        //Métodos
        public void Emprestimo(double qtd)
        {
            LimiteConta -= qtd;
            SaldoConta += qtd;
        }
	}
}
