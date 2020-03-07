﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Storage.Databases;

namespace PizzaBox.Storage.Migrations
{
    [DbContext(typeof(PizzaBoxDbContext))]
    partial class PizzaBoxDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Property<long>("CrustID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CrustID");

                    b.ToTable("Crusts");

                    b.HasData(
                        new
                        {
                            CrustID = 637191978135360896L,
                            Name = "Deep Dish",
                            Price = 3.50m
                        },
                        new
                        {
                            CrustID = 637191978135408457L,
                            Name = "New York Style",
                            Price = 2.50m
                        },
                        new
                        {
                            CrustID = 637191978135408495L,
                            Name = "Thin Crust",
                            Price = 1.50m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.Property<long>("PizzaID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CrustID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SizeID")
                        .HasColumnType("bigint");

                    b.HasKey("PizzaID");

                    b.HasIndex("CrustID");

                    b.HasIndex("SizeID");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PizzaTopping", b =>
                {
                    b.Property<long>("PizzaID")
                        .HasColumnType("bigint");

                    b.Property<long>("ToppingID")
                        .HasColumnType("bigint");

                    b.HasKey("PizzaID", "ToppingID");

                    b.HasIndex("ToppingID");

                    b.ToTable("PizzaTopping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Property<long>("SizeID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SizeID");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            SizeID = 637191978135418633L,
                            Name = "Large",
                            Price = 12.00m
                        },
                        new
                        {
                            SizeID = 637191978135418940L,
                            Name = "Medium",
                            Price = 10.00m
                        },
                        new
                        {
                            SizeID = 637191978135418954L,
                            Name = "Small",
                            Price = 8.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.Property<long>("ToppingID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ToppingID");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            ToppingID = 637191978135419574L,
                            Name = "Cheese",
                            Price = 0.25m
                        },
                        new
                        {
                            ToppingID = 637191978135419840L,
                            Name = "Pepperoni",
                            Price = 0.50m
                        },
                        new
                        {
                            ToppingID = 637191978135419851L,
                            Name = "Tomato Sauce",
                            Price = 0.75m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Crust", "Crust")
                        .WithMany("Pizzas")
                        .HasForeignKey("CrustID");

                    b.HasOne("PizzaBox.Domain.Models.Size", "Size")
                        .WithMany("Pizzas")
                        .HasForeignKey("SizeID");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PizzaTopping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Pizza", "Pizza")
                        .WithMany("PizzaToppings")
                        .HasForeignKey("PizzaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Topping", "Topping")
                        .WithMany("PizzaToppings")
                        .HasForeignKey("ToppingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
