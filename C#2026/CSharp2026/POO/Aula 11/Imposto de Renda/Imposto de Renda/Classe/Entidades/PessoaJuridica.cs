using Imposto_de_Renda.Classe.Entidades;
namespace Imposto_de_Renda.Classe.Entidades
{
    internal class PessoaJuridica : Contribuintes
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios)
            : base(nome, rendaAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public override double Imposto()
        {
            if (NumeroDeFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}