using SistemaBancario.Classes.Contextos;
using SistemaBancario.Classes.Entidades;

Console.WriteLine("=== Sistema Bancário ===\n");

using var context = new BancoContext();

// Verifica se o banco de dados existe e cria se necessário
// Cria as tabelas baseadas nas entidades configuradas no DbContext
context.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n--- MENU PRINCIPAL ---");
    Console.WriteLine("1 - Cadastrar nova conta");
    Console.WriteLine("2 - Consultar conta existente");
    Console.WriteLine("3 - Sair");
    Console.Write("\nEscolha uma opção: ");

    string opcao = Console.ReadLine()!;
    Console.WriteLine();

    switch (opcao)
    {
        case "1":
            CadastrarConta(context);
            break;
        case "2":
            ConsultarConta(context);
            break;
        case "3":
            continuar = false;
            Console.WriteLine("Encerrando sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

static void CadastrarConta(BancoContext context)
{
    Console.WriteLine("=== CADASTRO DE CONTA ===\n");

    Console.Write("Digite o número da conta: ");
    int numeroConta = int.Parse(Console.ReadLine()!);

    // Verifica se já existe uma conta com este número no banco de dados
    // FirstOrDefault retorna a primeira conta encontrada ou null se não existir
    var contaExistente = context.Contas.FirstOrDefault(c => c.NumeroConta == numeroConta);
    if (contaExistente != null)
    {
        // Se a conta já existe, exibe mensagem de erro e retorna sem cadastrar
        Console.WriteLine($"\nErro: Já existe uma conta com o número {numeroConta}!");
        return;
    }

    // Solicita o nome do titular da conta
    Console.Write("Digite o nome do titular: ");
    string titular = Console.ReadLine()!;

    // Pergunta se haverá depósito inicial
    Console.Write("Haverá depósito inicial (s/n)? ");
    // Converte a resposta para minúscula e verifica se é 's'
    bool temDepositoInicial = Console.ReadLine()!.ToLower() == "s";

    // Declara a variável que armazenará a conta criada
    Banco conta;

    // Se houver depósito inicial
    if (temDepositoInicial)
    {
        // Solicita o valor do depósito inicial
        Console.Write("Digite o valor do depósito inicial: ");
        decimal depositoInicial = decimal.Parse(Console.ReadLine()!);
        // Cria a conta COM depósito inicial
        conta = new Banco(numeroConta, titular, depositoInicial);
    }
    else
    {
        // Cria a conta SEM depósito inicial (saldo começa em zero)
        conta = new Banco(numeroConta, titular);
    }

    // Adiciona a nova conta ao contexto do Entity Framework
    context.Contas.Add(conta);
    // Persiste as alterações no banco de dados
    context.SaveChanges();

    // Confirma o cadastro e exibe os dados da conta criada
    Console.WriteLine("\n✓ Conta cadastrada com sucesso!");
    conta.ExibirDados();
}

static void ConsultarConta(BancoContext context)
{
    Console.WriteLine("=== CONSULTA DE CONTA ===\n");

    // Solicita o número da conta a ser consultada
    Console.Write("Digite o número da conta: ");
    int numeroConta = int.Parse(Console.ReadLine()!);

    // Busca a conta no banco de dados pelo número informado
    var conta = context.Contas.FirstOrDefault(c => c.NumeroConta == numeroConta);

    // Verifica se a conta foi encontrada
    if (conta == null)
    {
        // Se não encontrar, exibe mensagem e retorna
        Console.WriteLine($"\nConta {numeroConta} não encontrada!");
        return;
    }

    // Exibe os dados da conta encontrada
    conta.ExibirDados();

    // Variável de controle para o submenu de operações
    bool voltarMenu = false;

    // Loop do submenu - permite realizar várias operações na mesma conta
    while (!voltarMenu)
    {
        // Exibe o menu de operações disponíveis para a conta
        Console.WriteLine("--- OPERAÇÕES ---");
        Console.WriteLine("1 - Depositar");
        Console.WriteLine("2 - Sacar");
        Console.WriteLine("3 - Alterar titular");
        Console.WriteLine("4 - Voltar ao menu principal");
        Console.Write("\nEscolha uma opção: ");

        // Lê a opção escolhida
        string opcao = Console.ReadLine()!;
        Console.WriteLine();

        // Avalia a opção e executa a operação correspondente
        switch (opcao)
        {
            case "1":
                // OPERAÇÃO DE DEPÓSITO
                Console.Write("Digite o valor para depósito: ");
                decimal valorDeposito = decimal.Parse(Console.ReadLine()!);
                // Chama o método Depositar da conta que aumenta o saldo
                conta.Deposito(valorDeposito);
                // Salva as alterações no banco de dados
                context.SaveChanges();
                // Exibe os dados atualizados da conta
                conta.ExibirDados();
                break;

            case "2":
                // OPERAÇÃO DE SAQUE
                Console.Write("Digite o valor para saque: ");
                decimal valorSaque = decimal.Parse(Console.ReadLine()!);
                // Chama o método Sacar que diminui o saldo e cobra taxa de R$ 5,00
                conta.Saque(valorSaque);
                // Salva as alterações no banco de dados
                context.SaveChanges();
                // Exibe os dados atualizados da conta
                conta.ExibirDados();
                break;

            case "3":
                // OPERAÇÃO DE ALTERAÇÃO DE TITULAR
                Console.Write("Digite o novo nome do titular: ");
                string novoTitular = Console.ReadLine()!;
                // Altera o nome do titular (permitido conforme regra de negócio)
                conta.Titular = novoTitular;
                // Salva as alterações no banco de dados
                context.SaveChanges();
                Console.WriteLine("✓ Titular alterado com sucesso!");
                // Exibe os dados atualizados da conta
                conta.ExibirDados();
                break;

            case "4":
                // Encerra o loop do submenu e volta ao menu principal
                voltarMenu = true;
                break;

            default:
                // Opção inválida no submenu
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}