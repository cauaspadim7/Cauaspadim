using static System.Console;
try {
    //-------Declaração de variáveis-------
    double a, b, c; double areaQuadrado, areaTriangulo, areaTrapezio;  
    //-------Entrada de dados-------
    Write("Digite a medida A: ");
    a = double.Parse(ReadLine());
    Write("Digite a medida B: ");
    b = double.Parse(ReadLine());
    Write("Digite a medida C: ");
    c = double.Parse(ReadLine());
    //-------Processamento de dados-------
    areaQuadrado = a * a;
    areaTriangulo = (a * b) / 2;
    areaTrapezio = ((a + b) * c) / 2;
    //-------Saída de dados------------
    WriteLine($"Área do quadrado = {areaQuadrado:F4}");
    WriteLine($"Área do triângulo = {areaTriangulo:F4}");
    WriteLine($"Área do trapézio = {areaTrapezio:F4}");
}
catch (Exception)
{
   WriteLine("Valores inválidos inseridos, progama encerrado!"); 
}
