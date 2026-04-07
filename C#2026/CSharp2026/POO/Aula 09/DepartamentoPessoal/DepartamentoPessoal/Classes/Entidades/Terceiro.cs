namespace DepartamentoPessoal.Classes.Entidades
{
    internal class Terceiro : Funcionario
    {
        //Campo
        private double despesa;

        //Propriedades
        public double DespesaAdicional
        {
            get { return despesa; }
            set { despesa = value; }
        }

        //Construtor
        public Terceiro(string nomeColaborador, int jornadaTrabalho, double valorHora, double despesa) : base(nomeColaborador, jornadaTrabalho, valorHora)
        {
            DespesaAdicional = despesa;
        }

        //Método
        public override double Pagamento()
        {
            return base.Pagamento() + (DespesaAdicional * 0.2);
        }
    }
}