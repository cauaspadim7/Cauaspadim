namespace exemplo1
{
    internal class Produto
    {
        //Campos da classe
        string nome;
        double preco;
        int quantidade;

        //Construtor 
        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
        

        //Metodos 
        public double Valor_Total_Em_Estoque()
        {
            return preco * quantidade;
        }
        public void Adicionar_Produtos(int qtd)
        {
            quantidade += qtd;
        }

        public void Remover_Produtos(int qtd)
        {
            quantidade -= qtd;
        }

        public string Dados_do_Produto()
        {
            return $"Nome: {nome}, Preço: {preco}, Quantidade: {quantidade}, " +
                $"Total: {Valor_Total_Em_Estoque()}";
        }
    }
}