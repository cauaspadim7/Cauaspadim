using static System.Console;
using static System.ConsoleColor;
using static Circunferencia03.Calculadora;

Title = "Calculadora 03";
Write("Digite o raio da cirunferencia: ");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();
//Saida de dados
WriteLine($"Circunferencia é: {Circunferencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
Write($"PI: {PI}");