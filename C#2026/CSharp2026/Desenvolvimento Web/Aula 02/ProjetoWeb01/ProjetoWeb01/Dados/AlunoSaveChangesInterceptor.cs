using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using ProjetoWeb01.Classes.Enumeracoes;
using ProjetoWeb01.Classes.Entidades;

namespace ProjetoWeb01.Dados
{
    public class AlunoSaveChangesInterceptor : SaveChangesInterceptor
    {
        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
            DbContextEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            ProcessAlunoRegra(eventData.Context);
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        public override InterceptionResult<int> SavingChanges(
            DbContextEventData eventData,
            InterceptionResult<int> result)
        {
            ProcessAlunoRegra(eventData.Context);
            return base.SavingChanges(eventData, result);
        }

        private void ProcessAlunoRegra(DbContext context)
        {
            if (context == null) return;

            try
            {
                var entries = context.ChangeTracker.Entries<Aluno>().ToList();

                foreach (var entry in entries)
                {
                    if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                    {
                        var aluno = entry.Entity;

                        // Garantir que Regra NUNCA seja null
                        if (aluno.Regra == null)
                        {
                            aluno.Regra = TipoRegra.Usuario;
                        }

                        // Marcar a propriedade como modificada para garantir que seja enviada ao banco
                        entry.Property(a => a.Regra).CurrentValue = aluno.Regra;
                        entry.Property(a => a.Regra).IsModified = true;

                        Console.WriteLine($"[AlunoSaveChangesInterceptor] Aluno: {aluno.Nome}, Regra: {aluno.Regra} ({(int)aluno.Regra})");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AlunoSaveChangesInterceptor] Erro: {ex.Message}");
                throw;
            }
        }
    }
}
