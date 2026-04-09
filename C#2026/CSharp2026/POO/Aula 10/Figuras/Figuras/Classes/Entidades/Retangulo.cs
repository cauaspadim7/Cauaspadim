using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    internal class Retangulo : Forma
    {
		//Campos
        private double largura;
        private double altura;

        //Propiedades
		public double Largura
		{
			get { return largura; }
			set { largura = value; }
		}
        public  double Altura
		{
			get { return altura; }
			set { altura = value; }
		}

		//Construtor

        public Retangulo(Cor corDaForma, double largura, double altura) : base(corDaForma)
        {
			Largura = largura;
			Altura = altura;
        }
        /// <summary>
        ///  Calcula a area da forma usando dimensoes atuais.
        /// </summary>
        /// <returns> valor da área calculada com base na largura e altura do retangulo.</returns>


        //Métodos

        //Lampada
        public override double Area()
        {
           return Largura * Altura;
        }
            
    }
}
