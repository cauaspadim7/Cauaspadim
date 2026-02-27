using static System.Console;
//Declaraçao de variáveis 
double largura, comprimento, valor, area, preco;
//Entrada de dados
Write("Digite a largura do terreno:");
largura = double.Parse(ReadLine());
Write("Digite o comprimento do terreno:");
comprimento = double.Parse(ReadLine());
Write("Digite o valor do metro quadrado:");
valor = double.Parse(ReadLine());
//Processamento de dados
area = largura * comprimento;
preco = area * valor;
//Saida de dados
WriteLine($"A área do terreno é de {area} e o preço do terreno é de R$ {preco}");