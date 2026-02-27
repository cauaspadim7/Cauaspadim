using static System.Console;
//Problema Baskara
//-------Declaracao de variaveis-----
double a, b, c, delta, x1, x2;
//-------Entrada de dados-----
WriteLine("Digite o valor de a: ");
a = double.Parse(ReadLine());
WriteLine("Digite o valor de b: ");
b = double.Parse(ReadLine());
WriteLine("Digite o valor de c: ");
c = double.Parse(ReadLine());
//-------Processamento de dados-----
delta = b * b - 4 * a * c;
if (delta < 0)
//------Estrutura de controle de dicisao IF-----
{
    WriteLine("Raizes impossiveis");
}
else if (delta == 0)
{
    x1 = -b / (2 * a);
    x2 = x1;
    WriteLine($"X1 = {x1}nxX2 = {x2}");
}
else
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    WriteLine($"X1 = {x1}\nX2 = {x2}");
}