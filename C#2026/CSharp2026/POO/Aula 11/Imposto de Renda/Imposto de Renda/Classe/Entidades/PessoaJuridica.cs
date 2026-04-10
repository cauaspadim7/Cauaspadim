using Imposto_de_Renda.Classe.Entidades;

namespace Imposto_de_Renda.Classes.Entidades
{
    internal abstract class PessoaJuridica : Contribuintes
    {
        private int numero_de_funcionarios;


        protected int NumeroDeFuncionarios
        {
            get { return numero_de_funcionarios; }
            set { numero_de_funcionarios = value; }
        }


        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios) : base(nome, rendaAnual)
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
