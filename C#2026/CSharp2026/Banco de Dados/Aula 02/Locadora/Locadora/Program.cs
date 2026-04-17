using System.Globalization;
using Projeto.Entidades;
using Projeto.Servicos;

Console.WriteLine("Entre com os dados do aluguel");

Console.Write("Modelo do carro: ");
string modelo = Console.ReadLine();

Console.Write("Retirada (dd/MM/yyyy HH:mm): ");
DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Devolucao (dd/MM/yyyy HH:mm): ");
DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Preco por hora: ");
double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Preco por dia: ");
double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Veiculo v = new Veiculo(modelo);
AluguelCarro aluguel = new AluguelCarro(inicio, fim, v);

ServicoAluguel servico = new ServicoAluguel(precoHora, precoDia);
servico.ProcessarFatura(aluguel);

Console.WriteLine("\nFATURA:");
Console.WriteLine("Pagamento basico: " + aluguel.Fatura.PagamentoBasico.ToString("F2"));
Console.WriteLine("Imposto: " + aluguel.Fatura.Imposto.ToString("F2"));
Console.WriteLine("Pagamento total: " + aluguel.Fatura.Total().ToString("F2"));
   