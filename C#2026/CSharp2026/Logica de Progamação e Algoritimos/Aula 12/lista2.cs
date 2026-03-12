//Exercicio de lista com a estrutura de repetiçao for 
using static System.Console;

//-----Declaraçao e variaveis
int n;
List<double> numeros = new List<double>();
//-------Entrada de dados
WriteLine("Quantos numeros voce vai digitar");
n = int.Parse(ReadLine());

for (int i = 0; i < n ; i++)
{
    Write("Digite um numero: ");
    numeros.Add(double.Parse(ReadLine()));
}
    Write("Valores =");

for (int i = 0; i < n ; i++)
{
    Write($" {numeros [i]}");
}

Write($"\nSoma = {numeros.Sum()}");
Write($"\nMedia = {numeros.Average()}");