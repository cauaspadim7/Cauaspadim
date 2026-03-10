using static System.Console;

int n =0;

do
{
    Write(n);
    n++;
    Task.Delay(1000).Wait();
} while (n < 5);
    WriteLine("Fim pogama");




n = 0;
while (n < 5)
{
Write(n);
n++;
Task.Delay(1000).Wait();
}
WriteLine("Fim do pogama2");
