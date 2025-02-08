﻿// <auto-generated />
using InventoryManagmentApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryManagmentApp.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20250207222531_NombreDeLaMigracion")]
    partial class NombreDeLaMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InventoryManagmentApp.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Purchase", b =>
                {
                    b.Property<int>("PurchasesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchasesId"));

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Observations")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Taxes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PurchasesId");

                    b.HasIndex("UserId");

                    b.ToTable("purchases");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.PurchasesProduct", b =>
                {
                    b.Property<int>("PurchasesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("PurchasesId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("purchasesProducts");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Returns", b =>
                {
                    b.Property<int>("ReturnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReturnId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReturnId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("returns");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolId"));

                    b.Property<string>("RolDescription")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RolName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("RolId");

                    b.ToTable("rols");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SaleId");

                    b.HasIndex("UserId");

                    b.ToTable("sales");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.SaleProduct", b =>
                {
                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("SaleId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("salesProducts");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuplierNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SupplierAddress")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("SupplierId");

                    b.ToTable("suppliers");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("RolId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Product", b =>
                {
                    b.HasOne("InventoryManagmentApp.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Purchase", b =>
                {
                    b.HasOne("InventoryManagmentApp.Models.User", "User")
                        .WithMany("Purchases")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.PurchasesProduct", b =>
                {
                    b.HasOne("InventoryManagmentApp.Models.Product", "Product")
                        .WithMany("PurchasesProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagmentApp.Models.Purchase", "Purchases")
                        .WithMany("PurchasesProducts")
                        .HasForeignKey("PurchasesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Returns", b =>
                {
                    b.HasOne("InventoryManagmentApp.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagmentApp.Models.User", "User")
                        .WithMany("Returns")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Sale", b =>
                {
                    b.HasOne("InventoryManagmentApp.Models.User", "User")
                        .WithMany("Sales")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.SaleProduct", b =>
                {
                    b.HasOne("InventoryManagmentApp.Models.Product", "Product")
                        .WithMany("SaleProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagmentApp.Models.Sale", "Sale")
                        .WithMany("SaleProducts")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.User", b =>
                {
                    b.HasOne("InventoryManagmentApp.Models.Rol", "Rol")
                        .WithMany("Users")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Product", b =>
                {
                    b.Navigation("PurchasesProducts");

                    b.Navigation("SaleProducts");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Purchase", b =>
                {
                    b.Navigation("PurchasesProducts");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Rol", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Sale", b =>
                {
                    b.Navigation("SaleProducts");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("InventoryManagmentApp.Models.User", b =>
                {
                    b.Navigation("Purchases");

                    b.Navigation("Returns");

                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
