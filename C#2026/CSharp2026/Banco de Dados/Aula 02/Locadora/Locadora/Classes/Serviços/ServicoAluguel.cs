using Projeto.Entidades;

namespace Projeto.Servicos
{
    class ServicoAluguel
    {
        public double PrecoHora { get; set; }
        public double PrecoDia { get; set; }

        private TaxaServBrasil imposto = new TaxaServBrasil();

        public ServicoAluguel(double precoHora, double precoDia)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
        }

        public void ProcessarFatura(AluguelCarro aluguel)
        {
            double horas = (aluguel.Fim - aluguel.Inicio).TotalHours;

            double pagamentoBasico;

            if (horas <= 12.0)
            {
                double contador = 0;

                while (contador < horas)
                {
                    contador++;
                }

                pagamentoBasico = contador * PrecoHora;
            }
            else
            {
                double dias = horas / 24.0;

                double contador = 0;

                while (contador < dias)
                {
                    contador++;
                }

                pagamentoBasico = contador * PrecoDia;
            }

            double taxa = imposto.Calcular(pagamentoBasico);

            aluguel.Fatura = new Fatura(pagamentoBasico, taxa);
        }
    }
}