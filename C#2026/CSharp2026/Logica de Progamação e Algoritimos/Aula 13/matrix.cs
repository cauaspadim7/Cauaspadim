using static System.Console;
//Declaraçao de uma matriz 3x3
int [,] matriz = new int [3,3];

//entradada de dados, inserir valores na matriz
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write($"Digite o valor p/ a posiçao [{i},{j}]: ");
        matriz[i , j] = int.Parse(ReadLine());
    }
}
WriteLine("matriz preenchida: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write(matriz[i, j] + "\t");
    }
    WriteLine();
}





