using System;
using System.Globalization;
class Program
{
static void Main(string[] args)
{
CultureInfo ci = CultureInfo.InvariantCulture;
Console.Write("Preço unitário do produto: ");
double preco = double.Parse(Console.ReadLine(), ci);
Console.Write("Quantidade comprada: ");
int quantidade = int.Parse(Console.ReadLine());
Console.Write("Dinheiro recebido: ");
double dinheiro = double.Parse(Console.ReadLine(), ci);
double total = preco * quantidade;
double troco = dinheiro - total;
Console.WriteLine("TROCO = " + troco.ToString("F2", ci));
}
}
