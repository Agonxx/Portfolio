using ExemploApi.Core.Enums;
using ExemploApi.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ExemploApi.Database
{
    public class DatabaseApi : DbContext
    {
        public DatabaseApi(DbContextOptions<DatabaseApi> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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
                    Genero = EGenero.Masculino,
                    CriadoEm = DateTime.Now
                },
                new Usuario
                {
                    Id = 2,
                    Nome = "Fernando",
                    Email ="Fernando@gmail.com",
                    Genero = EGenero.Masculino,
                    CriadoEm = DateTime.Now
                }
            });
        }
    }

}
