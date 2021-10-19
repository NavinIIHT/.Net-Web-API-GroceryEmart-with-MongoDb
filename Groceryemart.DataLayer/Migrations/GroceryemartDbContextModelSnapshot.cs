﻿// <auto-generated />
using System;
using GroceryEmart.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroceryEmart.DataLayer.Migrations
{
    [DbContext(typeof(GroceryemartDbContext))]
    partial class GroceryemartDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GroceryEmart.Entities.ApplicationUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("HouseNo_Building_Name")
                        .IsRequired();

                    b.Property<long>("MobileNumber");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<long>("PinCode");

                    b.Property<string>("Road_area")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("GroceryEmart.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatId");

                    b.Property<bool>("OpenInNewWindow");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("GroceryEmart.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int>("CatId");

                    b.Property<string>("Description");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<int?>("ProductOrderOrderId");

                    b.Property<string>("photo");

                    b.Property<int>("stock");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductOrderOrderId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("GroceryEmart.Entities.ProductOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<int>("UserId");

                    b.HasKey("OrderId");

                    b.ToTable("productOrders");
                });

            modelBuilder.Entity("GroceryEmart.Entities.Product", b =>
                {
                    b.HasOne("GroceryEmart.Entities.ProductOrder", "ProductOrder")
                        .WithMany("Product")
                        .HasForeignKey("ProductOrderOrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
