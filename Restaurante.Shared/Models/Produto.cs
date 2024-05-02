using Microsoft.EntityFrameworkCore;

namespace Restaurante.Shared.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }

    public class RotasProduto
    {
        public const string ListarProdutos = "ListarProdutos";
    }

    public static class DBProduto
    {
        public static void SetarProduto(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>(
                r =>
                {
                    r.HasOne<Categoria>()
                    .WithMany()
                    .HasForeignKey(x => x.CategoriaId)
                    .OnDelete(DeleteBehavior.NoAction);
                });
        }
    }

}
