using static System.Console;

Write("Digite o tamanho da matriz (máx 10): ");
int n = int.Parse(ReadLine());

int[,] matriz = new int[n, n];
int negativos = 0;

// entrada de dados
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
    Write($"Digite o valor p/ a posição [{i},{j}]: ");
    matriz[i, j] = int.Parse(ReadLine());

    if (matriz[i, j] < 0)
        {
    negativos++; 
        }
    }
}
WriteLine();
WriteLine("Matriz preenchida:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write(matriz[i, j] + "\t");
    }
    WriteLine();
}

WriteLine();
WriteLine("Diagonal principal:");

for (int i = 0; i < n; i++)
{
    Write(matriz[i, i] + "\t");
}

WriteLine();
WriteLine("Quantidade de valores negativos: " + negativos);
