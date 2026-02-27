using System.Formats.Asn1;
using static System.Console;

double a, b, c, area;

Write("Lado A: ");
a = double.Parse(ReadLine());

Write("Lado B: ");
b = double.Parse(ReadLine());

Write("Lado C: ");
c = double.Parse(ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    double p = (a + b + c) / 2;
     area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

    WriteLine("Forma um triângulo.");
    WriteLine($"area = {area:F4}");
}
else
{
    WriteLine("Não forma um triângulo.");
    area = ((a + b) * c) / 2;
    WriteLine($"Area do trapezio: {area:F4}");
}
