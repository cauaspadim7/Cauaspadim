//Entrada de dados
Console.WriteLine("Digite um numero:");
string nome = Console.ReadLine();//Entrada de dados
System.Console.WriteLine($"O valor digitado é de {nome}");
System.Console.WriteLine("Digite o 1º numero:");
double x = double.Parse(Console.ReadLine());//sConversão de dados
System.Console.WriteLine("Digite o 2º numero:");
double y = double.Parse(Console.ReadLine());//Conversão de dados
//Processamento de dados
double soma = x + y;
//Saida de dados
System.Console.WriteLine($"A soma dos dois valores é de {soma}");
