using Figuras.Classes.Entidades;
using static System.Console;
using Figuras.Classes.Enumeracoes;


List<Forma> formas = new();
Write("Entre com a quantidade de formas: ");
int qtd = int.Parse(ReadLine());

for (int i = 0; i < qtd; i++)
{
    WriteLine($"Dados do objeto geometrico n° {i + 1}:");
    Write("Retangulo ou Circulo (R/C): ");
    char escolha= char.Parse(ReadLine().ToLower());
    if (escolha == 'r')
    {
        WriteLine("Qual é a cor do objeto? " +
            "\nt1 - Vermelha "  +
            "\nt2 - Azul " +
            "\nt3 - Amarela " +
            "\nt4 - Rosa ");
        int cor = int.Parse(ReadLine());
    }


