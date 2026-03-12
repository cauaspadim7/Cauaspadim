using static System.Console;
try{
//--------Declaração de um dicionario
Dictionary<int, double> produtos = new Dictionary<int, double>()
{
    {1, 5.00},
    {2, 3.50},
    {3, 4.80},
    {4, 8.90},
    {5, 7.32}
};

Write("Digite o código do produto: ");
    int codigo = int.Parse(ReadLine());

    Write("Digite a quantidade: ");
    int quantidade = int.Parse(ReadLine());

    double total = produtos[codigo] * quantidade;

    WriteLine($"O valor a ser pago é: {total:F2}");

}
catch(Exception)
{
    WriteLine("Codigo do produto invalido");
}