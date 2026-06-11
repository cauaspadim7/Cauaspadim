using Microsoft.EntityFrameworkCore;
using ProjetoWeb01.Classes.Entidades;
using ProjetoWeb01.Classes.Enumeracoes;


namespace ProjetoWeb01.Dados
{

    public class AlunoContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               @"Server =ECFP507D1319382\SQLEXPRESS02; Database = Aluno;Trusted_Connection = True; TrustServerCertificate=True;"
             );

            // Adicionar interceptor para garantir que Regra nunca seja null
            optionsBuilder.AddInterceptors(new AlunoSaveChangesInterceptor());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>(
              entity =>
              {
                  entity.HasKey(e => e.Id);
                  entity.Property(e => e.Nome).IsRequired();  //Nome
                  entity.Property(e => e.Email); //Email
                  entity.Property(e => e.Senha); //Senha
                  entity.Property(e => e.CursoID).IsRequired(); //Curso
                  entity.Property(e => e.RA).IsRequired(); //RA
                  entity.Property(e => e.StatusAction).IsRequired(); //StatusAction
                  entity.Property(e => e.StatusWIFI).IsRequired();//StatusWIFI
                  entity.Property(e => e.Regra)
                      .IsRequired()
                      .HasColumnName("TipoRegra")
                      .HasDefaultValueSql("0") // SQL DEFAULT value
                      .HasConversion<int>(); // Converter enum para int
              }

                );
        }
    }
}

