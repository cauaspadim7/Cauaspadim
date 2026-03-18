using ExemploComPOO;
using static System.Console;
//Intanciaçao dos triangulos X e Y
Triangulo  x = new Triangulo();
Triangulo y = new Triangulo();
//Entrada de dados
WriteLine("Digite as medidas do triangulo X");
WriteLine("Digite a medida de A");
x.ladoA = double.Parse(ReadLine());
WriteLine("Digite a medida de B");
x.ladoB = double.Parse(ReadLine());
WriteLine("Digite a medida de C");
x.ladoC = double.Parse(ReadLine());

WriteLine("Digite as medidas do triangulo Y");
Write("Digite a medida de A");
y.ladoA = double.Parse(ReadLine());
WriteLine("Digite a medida de B");
y.ladoB = double.Parse(ReadLine());
WriteLine("Digite a medida de C");
y.ladoC = double.Parse(ReadLine());

//Saida de dados
WriteLine($"A area do triangulo X é de {x.Area()}");
WriteLine($"A area do triangulo Y é de {y.Area()}");
ReadKey();