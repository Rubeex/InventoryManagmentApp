using InventoryManagmentApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Rol> rols { get; set; }    
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Returns> returns { get; set; }
        public DbSet<Sale> sales { get; set; }
        public DbSet<SaleProduct> salesProducts { get; set; }
        public DbSet<Purchase> purchases { get; set; }
        public DbSet<PurchasesProduct> purchasesProducts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Clave compuesta: usando las propiedades PurchaseId y ProductId
            modelBuilder.Entity<PurchasesProduct>()
                .HasKey(pp => new { pp.PurchasesId, pp.ProductId });

            // Clave compuesta: usando las propiedades SalesId y ProductId
            modelBuilder.Entity<SaleProduct>()
                .HasKey(pp => new { pp.SaleId, pp.ProductId });


            base.OnModelCreating(modelBuilder);
        }
    }
}
