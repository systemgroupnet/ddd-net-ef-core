﻿// <auto-generated />
using System;
using DDDEfCore.ProductCatalog.Infrastructure.EfCore.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DDDEfCore.ProductCatalog.Infrastructure.EfCore.Migrations
{
    [DbContext(typeof(ProductCatalogDbContext))]
    [Migration("20200802075818_Init_Database")]
    partial class Init_Database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DDDEfCore.ProductCatalog.Core.DomainModels.Catalogs.Catalog", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("DDDEfCore.ProductCatalog.Core.DomainModels.Catalogs.CatalogCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CatalogCategoryParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CatalogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatalogCategoryParentId");

                    b.HasIndex("CatalogId");

                    b.ToTable("CatalogCategory");
                });

            modelBuilder.Entity("DDDEfCore.ProductCatalog.Core.DomainModels.Catalogs.CatalogProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CatalogCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CatalogCategoryId");

                    b.ToTable("CatalogProduct");
                });

            modelBuilder.Entity("DDDEfCore.ProductCatalog.Core.DomainModels.Categories.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("DDDEfCore.ProductCatalog.Core.DomainModels.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DDDEfCore.ProductCatalog.Core.DomainModels.Catalogs.CatalogCategory", b =>
                {
                    b.HasOne("DDDEfCore.ProductCatalog.Core.DomainModels.Catalogs.CatalogCategory", "Parent")
                        .WithMany()
                        .HasForeignKey("CatalogCategoryParentId");

                    b.HasOne("DDDEfCore.ProductCatalog.Core.DomainModels.Catalogs.Catalog", null)
                        .WithMany("Categories")
                        .HasForeignKey("CatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DDDEfCore.ProductCatalog.Core.DomainModels.Catalogs.CatalogProduct", b =>
                {
                    b.HasOne("DDDEfCore.ProductCatalog.Core.DomainModels.Catalogs.CatalogCategory", "CatalogCategory")
                        .WithMany("Products")
                        .HasForeignKey("CatalogCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
