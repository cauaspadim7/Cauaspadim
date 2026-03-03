using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de alturas das pessoas: ");
        int numeroPessoas = int.Parse(Console.ReadLine());

        Console.Write("Digite a altura mínima (cm): ");
        int alturaMinima = int.Parse(Console.ReadLine());

        Console.Write("Digite a altura máxima (cm): ");
        int alturaMaxima = int.Parse(Console.ReadLine());

        int contador = 0;

        for (int i = 1; i <= numeroPessoas; i++)
        {
            Console.Write($"Digite a altura da pessoa número {i}: ");
            int altura = int.Parse(Console.ReadLine());

            if (altura >= alturaMinima && altura <= alturaMaxima)
            {
                contador++;
            }
        }

        Console.WriteLine($"{contador} pessoas que estão entre {alturaMinima} e {alturaMaxima} cm de altura.");
    }
}