using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Entidades;

namespace SistemaBancario.Classes.Contextos
{
    internal class BancoContext : DbContext
    {
        //Propiedades

        /// <summary>
        /// Representa a tabela de contas bancarias no banco de dados
        /// DbSet permite realizar operaçoes CRUD 
        /// </summary>
        public DbSet <Banco> Contas { get; set; }


        //Metodos 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = BancoDB.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Banco>(entity=>
           {
               entity.HasKey(e =>e.Id);
               entity.Property(e => e.NumeroConta).IsRequired();
               entity.Property(e => e.Titular).IsRequired().HasMaxLength(50);
               entity.Property(e => e.Saldo).HasColumnType("Decimal(18,2)");
           }
               
               );
        }

    }
}




