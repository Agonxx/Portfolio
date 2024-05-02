using Microsoft.EntityFrameworkCore;

namespace Global.Api.Database
{
    public class DBGlobal : DbContext
    {
        public DBGlobal(DbContextOptions<DBGlobal> options) : base(options)
        {
        }


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
        }
    }

}
