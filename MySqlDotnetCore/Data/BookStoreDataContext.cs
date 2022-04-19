using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySqlDotnetCore.Models;

namespace MySqlDotnetCore.Data{
    public class DataContext : DbContext
    {
        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConnectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.Is_Deleted);
            modelBuilder.Entity<ProductCategory>().HasQueryFilter(p => !p.Is_Deleted);
            modelBuilder.Entity<ProductType>().HasQueryFilter(p => !p.Is_Deleted);


        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    }
}