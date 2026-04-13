using Imposto_de_Renda.Classe.Entidades;
using static System.Console;

List<Contribuintes> contribuintes = new();

Write("Digite o numero de contribuintes ");
int qtd = int.Parse(ReadLine());

for  (int i = 0; i < qtd; i++)
{
    WriteLine($"Dados do contribuintes : {i + 1} ");
    Write($"Pessoas juridica ou física (J/F): ");
    WriteLine($"Dados de pessoa fisica: {i + 1} ");
    char escolha = char.Parse(ReadLine());
    if ( escolha == 'j')
    {
        WriteLine("Qual é o numero de funcionario" +
        "\n\t1 - Renda anual " +
        "\n\t2 - Nome");
        Write("Digite o nome da pessoa juridica: ");
        string nome = (ReadLine());
        Write("Digite a renda anual da empresa: ");
        double rendaAnual = double.Parse(ReadLine());
        Write("Digite a quantidade de funcionarios: ");
        int numeroFuncionarios = int.Parse(ReadLine());
    }
    else if  ( escolha == 'f')
    {
        WriteLine("Qual é a quantidade de gastos com a saude" +
        "\n\t1 - Renda anual " +
        "\n\t2 - Nome");
        Write("Digite os gastos com saude: ");
        double gastosSaude = double.Parse(ReadLine());
        Write("Digite a renda anual da pessoa fisica: ");
        double rendaAnual = double.Parse(ReadLine());
        Write("Digite o nome da pessoa fisica: ");
        string nome = (ReadLine());
    }

    foreach (var imposto in contribuintes)
    {
       Write(imposto.ToString());
    }
    
}