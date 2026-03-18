using static System.Console;

Title = "Calculadora de triangulo";

//Entrada de dados 
WriteLine("Digite as medidas do triangulo X");
Write("Digite o valor de a: ");
double ax = double.Parse(ReadLine());

Write("Digite o valor de b: ");
double bx = double.Parse(ReadLine());

Write("Digite o valor de c: ");
double cx = double.Parse(ReadLine());

WriteLine("Digite as medidas do triangulo Y");
Write("Digite o valor de a: ");
double ay = double.Parse(ReadLine());

Write("Digite o valor de b: ");
double by = double.Parse(ReadLine());

Write("Digite o valor de c: ");
double cy = double.Parse(ReadLine());

//Processamento de dados
double px = (ax + bx + cx) / 2;
double py = (ay + by + cy) / 2;

double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(py * (py - ay) * (py - by) * (py - cy));

//Saida de dados 
WriteLine($"A area do triangulo X é {areax:F2}");
WriteLine($"A area do triangulo Y é {areay:F2}");

if (areax > areay)
{
    WriteLine("Maior area é do triangulo x");
}
else if (areay > areax)
{
    WriteLine("Maior area é do triangulo Y");
}
else
{
    WriteLine("Os triangulos de areas iguais");
}
ReadKey();