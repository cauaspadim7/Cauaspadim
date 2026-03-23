using Aplicativo_de_dados_de_funcionarios;
using static System.Console;
DadosDeFuncionarios x = new DadosDeFuncionarios();

Write("Digite o nome do funcionario: ");
x.nome = ReadLine();
Write("Digite o salario bruto do funcionario: ");
x.salario = double.Parse(ReadLine());
Write("Digite o valor total a ser pago de imposto pelo funcionario: ");
x.imposto = double.Parse(ReadLine());

WriteLine("Dados do funcionario");
WriteLine($"Nome do funcionario: {x.nome}");
WriteLine($"Salario liquido: R$ {x.SalarioLiquido()}");

Write("Digite a porcentagem do aumento do salario do funcionario: ");
double porcentagem = double.Parse(ReadLine());
x.AumentarSalario(porcentagem);
WriteLine($"Salario aumentado em {porcentagem} %");

WriteLine("Dados do funcionario atualizados");
WriteLine($"Nome do funcionario: {x.nome}");
WriteLine($"Salario liquido: R$ {x.SalarioLiquido()}");