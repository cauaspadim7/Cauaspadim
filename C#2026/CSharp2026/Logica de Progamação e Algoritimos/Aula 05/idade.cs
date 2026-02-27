using static System.Console;
int anos, meses, dias;
Write("Digite a idade em dias: ");
dias = int.Parse(ReadLine());
anos = dias / 365;
meses = (dias % 365) / 30;
dias = (dias % 365) % 30;
WriteLine("Idade: " + anos + " anos, " + meses + " meses e " + dias + " dias.");
