using static System.Console;
//Declaraçoes de variaveis
int x, resultado;
while (true)
{
    Write("Digite um numero ou zero para sair");
    x = int.Parse(ReadLine());
    if (x == 0)
    {
        WriteLine("Progama encerrado");
        break;
    }

    if ((x % 2) == 0)
    {
        //Numero Par
        //Processamento de dados
    resultado = x + (x+2) + (x+4) + (x+6) + (x+8);
    }
    else
    {
        //Numero impar
        x = x + 1;
        resultado = x + (x+2) + (x+4) +(x+6) + (x+8);
    }
    WriteLine ($"Soma = {resultado}");
}