using static System.Console;
using static System.Linq.Enumerable;
List <string> nomes = new List<string>();
nomes.Add("Caua");
nomes.Add("Lucca");
nomes.Add("Borsato");
nomes.Add("Cleide");
foreach (var item in Range(0, nomes.Count))
{
    WriteLine(nomes[item]);
}

WriteLine("--------------------");
foreach (var item in Range(0, nomes.Count))
{
    WriteLine(nomes[item]);
}

WriteLine("--------------------");
WriteLine("Indice que contem 'Caua': " + nomes.Contains("Caua"));

nomes.Clear();
foreach (var item in Range(0, nomes.Count))
{
    WriteLine(nomes[item]);
}

