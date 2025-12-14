using CleanArchitecture.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistence
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options) 
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasOne(p=> p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p=> p.CategoryID)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Customer>()
           .HasMany(c => c.OrdersList)
           .WithOne(o => o.Customer)
           .HasForeignKey(o => o.CustomerID)
           .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
           .HasMany(o => o.ProductList)
           .WithMany(p => p.OrdersList)
           .UsingEntity<Dictionary<string, object>>( 
           "OrderProduct",
           j => j.HasOne<Product>()
                 .WithMany()
                 .HasForeignKey("ProductId")
                 .OnDelete(DeleteBehavior.Cascade),
           j => j.HasOne<Order>()
                 .WithMany()
                 .HasForeignKey("OrderId")
                 .OnDelete(DeleteBehavior.Cascade),
           j =>
           {
               j.HasKey("OrderId", "ProductId"); 
           }
       );










        }


        }
}
