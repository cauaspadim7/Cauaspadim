using static System.Console;
using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Contextos;
using var context = new BancoContext();

//Verica se o db existe e cria se necessário
//Cria as tabelas baseadas na entidades configuradas
context.Database.EnsureCreated();

//Menu no programa
WriteLine("=== Sistema Bancário ===");
WriteLine("\n---MENU PRINCIPAL---");
WriteLine("1 - Cadastrar nova conta");
WriteLine("2 - Consultar conta existente");
WriteLine("3 - Sair\n");
Write("Escolha uma opção: ");