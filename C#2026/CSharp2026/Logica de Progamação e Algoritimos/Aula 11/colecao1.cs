using static System.Console;

int [] numeros = new int [5];
string [] nomes  = {"Joao", "Maria", "Pedro", "Ana", "Lucas"};

WriteLine(nomes [2]);
numeros [0] = 10;
numeros [1] = 10;
WriteLine(numeros [1]);
numeros [2] = 0;
numeros [3] = 5;
numeros [4] = 7;
int tamanho  = numeros.Length; //tamanho do vetor
WriteLine("O tamanho do vetor é: " + tamanho);
numeros.GetType(); //tipo do valor

