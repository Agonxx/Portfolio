using Microsoft.EntityFrameworkCore;

namespace Restaurante.Shared.Models
{
    public class ItemComanda
    {
        public int Id { get; set; }
        public int ComandaId { get; set; }
        public int ProdutoId { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInclusao { get; set; } = DateTime.Now;
    }

    public class RotasItemComanda
    {
    }

    public static class DBItemComanda
    {
        public static void SetarItemComanda(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemComanda>(
                r =>
                {
                    r.HasOne<Comanda>()
                    .WithMany()
                    .HasForeignKey(x => x.ComandaId)
                    .OnDelete(DeleteBehavior.Cascade);
                    
                    r.HasOne<Produto>()
                    .WithMany()
                    .HasForeignKey(x => x.ProdutoId)
                    .OnDelete(DeleteBehavior.NoAction);
                });
        }
    }
}
