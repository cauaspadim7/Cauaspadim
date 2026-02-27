using static System.Console;
//----Declarando variáveis-----
double nota1, nota2, resultado;
//----Entrada de dados-----
WriteLine("Digite a 1 nota: ");
nota1 = double.Parse(ReadLine());
WriteLine("Digite a 2 nota: ");
nota2 = double.Parse(ReadLine());
//----Processamento de dados-----
resultado = nota1 + nota2;
if (resultado <  60)
{
    WriteLine($"Nota final = {resultado}");
    WriteLine("reprovado");
}
else
{
WriteLine($"Nota final = {resultado}");
WriteLine("aprovado");
}