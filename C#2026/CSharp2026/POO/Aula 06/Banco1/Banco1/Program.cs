using Banco1;
using static System.Console;
Title = "Cadastro de conta";
ContaBancaria conta;

//Entrada de dados
Write("Entre com o numero da conta: ");
int n = int.Parse(ReadLine());
Write("Entre com o nome titular da conta: ");
string nome = ReadLine();
Write("Deseja fazer deposito inicial (s/n): ");
char resposta = char.Parse(ReadLine().ToLower());

if (resposta == 's')
{
    Write("Entre com o valor de deposito inicial: ");
    double dep = double.Parse(ReadLine());
    conta = new ContaBancaria(n, nome, dep);
}
else
{
    conta = new(n, nome);

}
conta.Dados();
ReadKey();

