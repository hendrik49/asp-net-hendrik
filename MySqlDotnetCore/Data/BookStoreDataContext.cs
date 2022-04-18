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
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    }
}