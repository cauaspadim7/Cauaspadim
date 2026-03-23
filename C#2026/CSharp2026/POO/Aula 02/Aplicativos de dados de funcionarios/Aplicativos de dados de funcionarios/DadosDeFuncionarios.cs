namespace Aplicativo_de_dados_de_funcionarios
{
    internal class DadosDeFuncionarios
    {
        public string nome;
        public double salario;
        public double imposto;


        public double SalarioLiquido()
        {
            double SalarioLiquido = salario - imposto;
            return SalarioLiquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            salario = salario + (salario * porcentagem / 100);
        }



    }
}