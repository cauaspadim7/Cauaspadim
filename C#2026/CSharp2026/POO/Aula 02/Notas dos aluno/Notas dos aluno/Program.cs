using Notas_do_aluno;
using static System.Console;
Aluno x = new Aluno();

Write("Digite o nome do aluno: ");
x.nome = ReadLine();
Write("Digite as tres notas do aluno: ");
x.nota1 = double.Parse(ReadLine());
x.nota2 = double.Parse(ReadLine());
x.nota3 = double.Parse(ReadLine());

if (x.NotaFinal() < 60)
{
    x.QuantoFaltou();
}

WriteLine($"Nota final do aluno: {x.NotaFinal()}");
WriteLine(x.AprovadoOuReprovado() ? "Reprovado" : "Aprovado");
WriteLine($"{x.QuantoFaltou()} pontos");