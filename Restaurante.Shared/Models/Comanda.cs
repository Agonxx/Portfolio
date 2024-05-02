using Microsoft.EntityFrameworkCore;
using Restaurante.Shared.Enums;

namespace Restaurante.Shared.Models
{
    public class Comanda
    {
        public int Id { get; set; }
        public int AtendenteId { get; set; }
        public EStatusComanda StatusComanda { get; set; } = EStatusComanda.Aberta;
        public EStatusPagamento StatusPagamento { get; set; } = EStatusPagamento.Pendente;
        public DateTime Abertura { get; set; } = DateTime.Now;
        public DateTime Encerramento { get; set; } = DateTime.Now;
    }

    public class RotasComanda
    {
        public const string ListarComandasAbertas = "ListarComandasAbertas";
    }

    public static class DBComanda
    {
        public static void SetarComanda(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comanda>(
                r =>
                {
                    r.HasOne<Usuario>()
                    .WithMany()
                    .HasForeignKey(x => x.AtendenteId)
                    .OnDelete(DeleteBehavior.NoAction);
                });
        }
    }

}
