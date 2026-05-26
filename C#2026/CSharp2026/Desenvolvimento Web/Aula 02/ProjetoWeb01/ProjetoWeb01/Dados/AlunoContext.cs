using Microsoft.EntityFrameworkCore;
using ProjetoWeb01.Classes.Entidades;


namespace ProjetoWeb01.Dados
{

    public class AlunoContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    }
}

