using static System.Console;
//Declaraçoes de variaveis
const int SENHAFIXA = 2002;
int senha, contagem = 0;
//Entrada de Dados
Write("Digite a senha");
senha = int.Parse(ReadLine());
//Processamento de dados
while (senha != SENHAFIXA)
{
    if (contagem >= 3)
    {
    WriteLine("Acesso Bloqueado");
    break;
    }
    Write("Senha incorreta, digite novamente: ");
    senha = int.Parse(ReadLine());

}
if (contagem < 3)
{
WriteLine("Acesso permitido!");
}
else
{
    WriteLine("Acesso negado");
}