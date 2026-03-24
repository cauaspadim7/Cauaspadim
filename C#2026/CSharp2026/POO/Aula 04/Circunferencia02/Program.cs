using Circunferencia02;
using static System.Console;
using static System.ConsoleColor;

Title = "Calculadora 02";

//Entrada de dados 
Write("Digite o raio da circunferencia: ");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();
//Criar o objeto do tipo Calculadora
Calculadora c1 = new Calculadora (raio);
Calculadora c2 = new Calculadora(raio);

//Saida de dados
WriteLine($"Circunferencia: {c1.Circunferencia():F2}");
WriteLine($"Volume: {c1.Volume():F2}");
WriteLine($"PI: {c1.Pi()}");
