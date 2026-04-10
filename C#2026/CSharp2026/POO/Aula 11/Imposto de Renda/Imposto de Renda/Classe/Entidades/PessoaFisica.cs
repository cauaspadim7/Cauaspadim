
using Imposto_de_Renda.Classe.Entidades;

namespace Imposto_de_Renda.Classes.Entidades;
internal abstract class PessoaFisica : Contribuintes
{
    public double GastosSaude { get; set; }

    public PessoaFisica(string nome, double rendaAnual, double gastosSaude)
        : base(nome, rendaAnual)
    {
        GastosSaude = gastosSaude;
    }

    public override double Imposto()
    {
        double imposto;

        
        if (RendaAnual < 20000.0)
        {
            imposto = RendaAnual * 0.15;
        }
        else
        {
            imposto = RendaAnual * 0.25;
        }

     
        imposto -= GastosSaude * 0.5;

        return Imposto();
    }
}