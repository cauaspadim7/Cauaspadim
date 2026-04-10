using Imposto_de_Renda.Classe.Contratos;
namespace Imposto_de_Renda.Classe.Entidades;
internal abstract class Contribuintes : Iimposto
{
    private string nome;
    private double renda_anual;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double RendaAnual
    {
        get { return renda_anual; }
        set { renda_anual = value; }
    }

    public Contribuintes(string nome, double rendaAnual_)
    {
        Nome = nome;
        RendaAnual = rendaAnual_; 
    }

    public abstract double Imposto();
}








