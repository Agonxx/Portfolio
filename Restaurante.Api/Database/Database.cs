using Microsoft.EntityFrameworkCore;
using Restaurante.Shared.Models;

namespace ExemploApi.Database
{
    public class DatabaseApi : DbContext
    {
        public DatabaseApi(DbContextOptions<DatabaseApi> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ItemComanda> ItensComandas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SetarItemComanda();
            modelBuilder.SetarComanda();
            modelBuilder.SetarProduto();
            modelBuilder.Seed();
        }

    }

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().HasData(new Usuario[]
            {
                new Usuario {
                    Id = 1,
                    Nome = "Rafael",
                    Email ="Rafael@gmail.com",
                }
            });
        }
    }

}
