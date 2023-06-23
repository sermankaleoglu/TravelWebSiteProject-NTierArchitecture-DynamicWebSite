using Microsoft.EntityFrameworkCore;
using TravelWebSite.entity;

namespace TravelWebSite.data.Concrete.EFCore
{
    public class TravelWebSiteContext:DbContext
    {
        public DbSet<Product>Products {get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }   
        public DbSet<ProductCity> ProductCities { get; set; } // ProductCity DbSet'ini ekleyin

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TravelWebSiteDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
            .HasKey(c=>new {c.CategoryId,c.ProductId});
                        
            modelBuilder.Entity<ProductCity>() // ProductCity entity'si için birincil anahtar tanımlayın
            .HasKey(pc => new { pc.ProductId, pc.CityId });

                // City tablosunu ekleyin
            modelBuilder.Entity<City>()
            .ToTable("City");

            modelBuilder.Entity<ProductCategory>()
            .ToTable("ProductCategories");

            base.OnModelCreating(modelBuilder);
        }
        
    }
}