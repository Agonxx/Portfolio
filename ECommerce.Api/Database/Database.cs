using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Database
{
    public class DBECommerce : DbContext
    {
        public DBECommerce(DbContextOptions<DBECommerce> options) : base(options)
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
