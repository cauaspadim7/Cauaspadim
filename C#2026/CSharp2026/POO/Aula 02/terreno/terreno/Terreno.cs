using System;
using System.Collections.Generic;
using System.Text;

namespace terreno
{
    internal class Terreno
    {
        //Campos
        public double largura, comprimento, valor;

        //Construtor
        public Terreno(double largura, double comprimento, double valor)
        {
            this.largura = largura;
            this.comprimento = comprimento;
            this.valor = valor;
        }


        //Metodos
        public double Area()
        {
            return largura * comprimento;
        }
        public double Preco()
        {
            return Area() * valor;
        }
        
        public void Saida()
        {
            Console.WriteLine($"Area do tereno = {Area()}");
            Console.WriteLine($"Preço do terreno = R$ {Preco()}");
        }
    }
}

