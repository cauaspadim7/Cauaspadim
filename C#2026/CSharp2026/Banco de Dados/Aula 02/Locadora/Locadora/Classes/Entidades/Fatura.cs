namespace Projeto.Entidades
{
    class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }

        public Fatura(double pagamentoBasico, double imposto)
        {
            PagamentoBasico = pagamentoBasico;
            Imposto = imposto;
        }

        public double Total()
        {
            return PagamentoBasico + Imposto;
        }
    }
}