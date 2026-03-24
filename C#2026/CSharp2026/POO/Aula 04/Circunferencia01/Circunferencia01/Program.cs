using static System.Console;
using static System.ConsoleColor;

Title = "Calculadora 01";

//Declaraçao de variaveis
double raio;
const double PI = 3.14;

//Entrada de dados
Write("Entre com o valor do raio da circunferncia: ");
ForegroundColor = Red;
raio = double.Parse(ReadLine());
ResetColor();

//Saida de dados
WriteLine($"Circunferencia: {Circunferencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
WriteLine($"PI:  {PI}");

//Calculo da circunferencia 
double Circunferencia(double r)
{
    return 2 * PI * raio;
}
//Calcular o volume
double Volume(double r)
{
    return (4 / 3) * PI * r;
}