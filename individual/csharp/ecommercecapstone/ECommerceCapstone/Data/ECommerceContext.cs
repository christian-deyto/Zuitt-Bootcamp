using Microsoft.EntityFrameworkCore;
using ECommerceCapstone.Models;

namespace ECommerceCapstone.Data
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18, 2)"); // Use the appropriate precision and scale for your application

            // Any other entity configurations you may have

            base.OnModelCreating(modelBuilder);
        }
    }
}
