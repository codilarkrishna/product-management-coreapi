using PMS.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PMS.Repository.PmsDbContext
{
    public class PmsDbContext : DbContext
    {
        public PmsDbContext(DbContextOptions<PmsDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed data for products
           
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 100001,
                    Name = "Sample Product",
                    Description = "Test product for demonstration",
                    Price = 10,
                    Stock = 100,
                    CreationDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Product
                {
                    Id = 100002,
                    Name = "Laptop Pro",
                    Description = "High-end laptop for professionals",
                    Price = 1500,
                    Stock = 50,
                    CreationDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                 new Product
                 {
                     Id = 100003,
                     Name = "Wireless Mouse",
                     Description = "Ergonomic wireless mouse",
                     Price = 50,
                     Stock = 200,
                     CreationDate = DateTime.UtcNow,
                     LastUpdated = DateTime.UtcNow
                 },
                 new Product
                 {
                     Id = 100004,
                     Name = "Office Chair",
                     Description = "Comfortable office chair",
                     Price = 150,
                     Stock = 100,
                     CreationDate = DateTime.UtcNow,
                     LastUpdated = DateTime.UtcNow
                 },
                    new Product
                    {
                        Id = 100005,
                        Name = "Smartphone X",
                        Description = "Latest smartphone with advanced features",
                        Price = 999,
                        Stock = 75,
                        CreationDate = DateTime.UtcNow,
                        LastUpdated = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = 100006,
                        Name = "Gaming Console",
                        Description = "Next-gen gaming console",
                        Price = 499,
                        Stock = 30,
                        CreationDate = DateTime.UtcNow,
                        LastUpdated = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = 100007,
                        Name = "Bluetooth Speaker",
                        Description = "Portable Bluetooth speaker with high-quality sound",
                        Price = 120,
                        Stock = 150,
                        CreationDate = DateTime.UtcNow,
                        LastUpdated = DateTime.UtcNow
                    }
            );
        }

    }

}

