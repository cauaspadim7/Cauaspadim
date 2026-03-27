using Banco;
using static System.Console;
using static System.Globalization.CultureInfo;

Title = "Abertura de conta";
ContaBancaria conta;

WriteLine("Abertura de conta - Nika Investiment");
Write("Entre com um número de conta: ");
int numero = int.Parse(ReadLine());
Write("Entre com o nome do titular: ");
string nome = ReadLine();
Write("Deja fazer um deposito inicial (s/n): ");
char resposta = char.Parse(ReadLine().ToLower());

if (resposta == 's')
{
    Write("Entre com o valor de deposito inicial: R$ ");
    double deposito = double.Parse(ReadLine());
    conta = new ContaBancaria(numero, nome, deposito);
}
else
{
    conta = new ContaBancaria(numero, nome);
}

conta.Dados();

WriteLine("Entre com um valor para deposito: R$ ");
double quantia = double.Parse(ReadLine());
conta.Deposito(quantia);
conta.Dados();
WriteLine("Entre com um valor para saque: R$ ");
quantia = double.Parse(ReadLine());
conta.Saque(quantia);
conta.Dados();

ReadKey();