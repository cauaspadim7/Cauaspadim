using static System.Console;

//declaraçao de variaveis
int visitantes = 0, contagem = 0;
double altura_max = 0, altura_min = 0, altura = 0;

try
{
    //entrada de dados
    Write("Digite o numero de visitantes: ");
    visitantes = int.Parse(ReadLine());

    Write("Digite a altura maxima: ");
    altura_max = double.Parse(ReadLine());

    Write("Digite a altura minima: ");
    altura_min = double.Parse(ReadLine());

    //Processamento de dados
    for(int i = 0; i < visitantes; i++)
    {
        Write($"Digite a altura da pessoa N° {i+1}: ");
        altura = double.Parse(ReadLine());

        if ((altura >= altura_min) && (altura <= altura_max))
        {
            contagem++;
        }
    }

    WriteLine($"O numero de pessoas que podem entrar no parque é de {contagem}");
}
catch (Exception ex)
{
   WriteLine($"Valor invalido, digite numerais. Error = {ex.Message}");
}
