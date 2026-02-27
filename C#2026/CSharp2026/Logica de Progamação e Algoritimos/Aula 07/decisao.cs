double resultado = 10;
//-------------Entrada de dados-----------------
System.Console.WriteLine("Digite o numerador para realizar divisão: ");
double entrada = double.Parse(Console.ReadLine());
System.Console.WriteLine("Digite o denominador para realizar a divisão");
double senai = double.Parse(Console.ReadLine());
//------Processamento de dados-----
if ( (entrada > 0) & (senai > 0) )
{
    resultado = 2 / entrada;
}
else if (entrada == 0)
{
    resultado  = 2 - entrada;
}

else
{
    resultado = 2 + entrada;
}
// -------Saída de dados----------
System.Console.WriteLine($"O resultado é {resultado}");

