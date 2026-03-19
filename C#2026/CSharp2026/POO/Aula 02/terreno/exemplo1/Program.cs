using exemplo1;
using static System.Console;

WriteLine("Entre com os dados do produto: ");

Write("Nome: ");
string nome = ReadLine();
Write("Preço: ");
double preco = double.Parse(ReadLine());
Write("Quantidade: ");
int qtd = int.Parse(ReadLine());

Produto p = new Produto(nome, preco, qtd);

WriteLine($"Dados do produto {p.Dados_do_Produto()}");

Write("Digite a quantidade de produtos a ser adicionados no estoque: ");
qtd = int.Parse(ReadLine());
p.Adicionar_Produtos(qtd);
WriteLine($"Dados atualizados: {p.Dados_do_Produto()}");
Write("Digite a quantidade de produtos a ser removida do estoque: ");
qtd = int.Parse(ReadLine());
p.Remover_Produtos(qtd);
Write($"Dados atualizados: {p.Dados_do_Produto()}");
ReadKey();