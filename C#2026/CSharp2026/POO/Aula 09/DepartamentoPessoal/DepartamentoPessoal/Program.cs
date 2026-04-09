using DepartamentoPessoal.Classes.Entidades;
using static System.Console;


List<Funcionario> colaboradores = new();

Write("Quantos funcionarios irá cadastrar: ");
int n = int.Parse(ReadLine());

for (int i = 0; i < n; i++)
{
    WriteLine($"Coloborador nº {i + 1}");
    Write("O funcionario é terceirizado (s/n): ");
    char e = char.Parse(ReadLine().ToLower());
    if (e == 'n')
    {
        Write("Nome: ");
        string nome = ReadLine();
        Write("Horas trabalhadas: ");
        int h = int.Parse(ReadLine());
        Write("Valor da hora: ");
        double v = double.Parse(ReadLine());
        colaboradores.Add(new Funcionario(nome, h, v));
    }
    else
    {
        Write("Nome: ");
        string nome = ReadLine();
        Write("Horas trabalhadas: ");
        int h = int.Parse(ReadLine());
        Write("Valor da hora: ");
        double v = double.Parse(ReadLine());
        Write("Depesa adicional: R$ ");
        double d = double.Parse(ReadLine());
        colaboradores.Add(new Funcionario(nome, h, v));
    }


}

    WriteLine("-Pagamentos-");
    foreach (var colab in colaboradores)
    {
        WriteLine(colab.ToString());
    }































































































































































































































































