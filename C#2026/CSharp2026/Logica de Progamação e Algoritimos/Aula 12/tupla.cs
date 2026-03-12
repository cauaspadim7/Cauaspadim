//Tupla
using static System.Console;
var clodoaldo = (34, 34, "Heitor", "SENAI", 'B');

WriteLine($"idade do clodoaldo: {clodoaldo.Item1}");
WriteLine($"idade do clodoaldo: {clodoaldo.Item2}");
WriteLine($"Nome do filho do clodo: {clodoaldo.Item3}");
clodoaldo.Item1 =54;
WriteLine($"idade do clodoaldo: {clodoaldo.Item1}");

(int, int , int) numeros = (1 , 2 ,5);
WriteLine($"Numeros da tupla: {numeros.Item1}, {numeros.Item2}, {numeros.Item3}");

