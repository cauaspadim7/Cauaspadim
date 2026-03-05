using System;

class ControleLençois
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aplicativo de controle de fluxo carros");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Parque Nacional os Lençóis Maranhenses\n");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Bem-vindo ao aplicativo de controle de fluxo de carros!");

        int veiculosNoParque = 0;
        int turistasNoParque = 0;

        while (true)
        {
            Console.ResetColor();
            Console.WriteLine("Digite o fluxo de carro (entrada/saida)");
            Console.WriteLine(" ou sair para encerrar a aplicação:");

            string movimento = Console.ReadLine().Trim().ToLower();

            if (movimento == "sair")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Saindo do aplicativo...");
                Console.WriteLine("Aplicativo encerrado.");
                break;
            }

            if (movimento != "entrada" && movimento != "saida")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Por favor, digite 'entrada' ou 'saida'.");
                continue;
            }

            Console.ResetColor();
            Console.WriteLine("Digite o número de turistas:");

            int turistas;
            if (!int.TryParse(Console.ReadLine(), out turistas) || turistas < 0 || turistas > 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Quantidade inválida. Informe um número entre 0 e 4.");
                continue;
            }

            string dataHora = DateTime.Now.ToString("ddd MMM dd HH:mm:ss yyyy");

            if (movimento == "entrada")
            {
                veiculosNoParque++;
                turistasNoParque += turistas;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Entrada registrada em: {dataHora}");
                Console.WriteLine($"Entrada de {turistas} turistas registrada.");
            }
            else
            {
                veiculosNoParque--;
                turistasNoParque -= turistas;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Saída registrada em: {dataHora}");
                Console.WriteLine($"Saída de {turistas} turistas registrada.");
            }

            Console.ResetColor();
            Console.WriteLine($"Total de turistas no parque: {turistasNoParque}");
        }
    }
}