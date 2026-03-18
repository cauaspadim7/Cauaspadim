namespace ExemploComPOO
{
    internal class Triangulo
    {
        //Campos ou atributos
        public double ladoA;
        public double ladoB;
        public double ladoC;

        //Metodo
        public double Area()
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(p * (p - ladoA) * (p - ladoB)  + (ladoC));
            return area;
        }
    }
}
