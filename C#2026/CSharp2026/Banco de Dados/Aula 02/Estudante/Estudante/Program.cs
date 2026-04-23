using Microsoft.EntityFrameworkCore;
using Estudante.Classes.Entidades;
using Estudante.Classes.Dados;

using var context = new AlunoContext();

context.Database.EnsureCreated();

Aluno pessoa1 = new Aluno("Caua", 12345, "Phython");
context.Alunos.Add(pessoa1);
context.SaveChanges();

