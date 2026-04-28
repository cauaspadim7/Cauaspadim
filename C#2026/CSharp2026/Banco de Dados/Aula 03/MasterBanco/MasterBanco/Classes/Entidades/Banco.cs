using Microsoft.Data.SqlClient;

namespace MasterBanco.Classes.Entidade
{
    internal class Banco
    {
        //Campo
        private const decimal TaxaSaque = 5.00m;

        //Propriedades
        public int Id { get; set; }
        public string Titular { get; set; }
        public int Numero_da_conta { get; set; }
        public decimal Saldo { get; set; }


        //Construtores
        public Banco() { }

        public Banco(string titular, int numero_da_conta, decimal saldo)
        {
            Titular = titular;
            Numero_da_conta = numero_da_conta;
            Saldo = saldo;
        }

        public Banco(string titular, int numero_da_conta) : this()
        {
            Saldo = 0;
        }

        //Caminho do servidor onde está o banco de dados
        private static string ConectarCaminho = @"Server = ECFP507D1319382\SQLEXPRESS; Database=Clodoaldo;Trusted_Connection=True;TrustServerCertificate=True;";
        //Operações CRUD
        //C - Create

        public static void CadastrarContas(Banco banco)
        {
            //Query
            string consulta = "INSERT INTO " +
                "Contas (Titular,Numero_da_Conta,Saldo)" +
                "Values" +
                "(@Titular, @Numero_da_conta, @Saldo)";
            using (SqlConnection conexao = new SqlConnection(ConectarCaminho))
            using (SqlCommand comando = new SqlCommand(consulta, conexao))
            {
                comando.Parameters.AddWithValue("@Titular", banco.Titular);
                comando.Parameters.AddWithValue("@Numero_da_conta", banco.Numero_da_conta);
                comando.Parameters.AddWithValue("@Saldo", banco.Saldo);

                conexao.Open();
                int resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    Console.WriteLine($"Conta cadastrado com sucesso!");
                }
            }
        }

        //R - Read
        public static void LerContas()
        {
            string consulta = "SELECT Id, Titular,Numero_da_conta,Saldo FROM Contas";
            using (SqlConnection conexao = new SqlConnection(ConectarCaminho))
            using (SqlCommand comando = new SqlCommand(consulta, conexao))
            {
                conexao.Open();
                using (SqlDataReader leitura = comando.ExecuteReader())
                {
                    if (leitura.HasRows)
                    {
                        while (leitura.Read())
                        {
                            Console.WriteLine($"ID:{leitura["ID"]} | " +
                                $" Conta: {leitura["Numero_da_Conta"]} | " +
                                $" Titular: {leitura["Titular"]} | " +
                                $" Saldo: R$ {leitura["Saldo"]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma conta encontrada");
                    }
                }
            }
        }
    }
}
