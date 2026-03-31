using static System.Console;
using Heranca;

PessoaFissica spadim =  new PessoaFissica(12345, "Spadim");
PessoaJuridica senai = new PessoaJuridica(54321, "Skaf", 12000.00);

WriteLine(spadim);//Imprimir somente o obj
WriteLine(spadim.ToString());//Imprimi e converte o obj p/ string
