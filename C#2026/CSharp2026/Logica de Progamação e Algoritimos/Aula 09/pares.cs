using static System.Console;
//Declaração de variaveis
int numero, valor;
try
{
    Write("Quantos números você vai digitar?");
    numero = int.Parse(ReadLine());
    //Processamento de dados
    for (int i = 0; i<numero; i++)
    {
        Write("Digite um numero: ");
        valor = int.Parse(ReadLine());
        if (valor < 0)
        {
            Write("Negativo");
        }
        else if (valor > 0)
        {
            Write("Positivo");
        }
        else
        {
            Write("Nulo");
        }
        if ((valor % 2 ) == 0)
        {
            WriteLine(" PAR");
        }
        else if ((valor % 2 ) != 0)
        {
            WriteLine(" IMPAR");
        }
    }
}
catch (Exception ex)
{
    WriteLine("valor invalido, erro =", ex.Message);
}