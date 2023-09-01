﻿// <auto-generated />
using FoodiApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodiApp.Migrations
{
    [DbContext(typeof(FoodieDBContext))]
    partial class FoodieDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodiApp.Models.FoodCategory", b =>
                {
                    b.Property<int>("FoodCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodCategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodCategoryId");

                    b.ToTable("FoodCategories");

                    b.HasData(
                        new
                        {
                            FoodCategoryId = 1,
                            Name = "Breakfast"
                        },
                        new
                        {
                            FoodCategoryId = 2,
                            Name = "Lunch"
                        },
                        new
                        {
                            FoodCategoryId = 3,
                            Name = "FastFood"
                        });
                });

            modelBuilder.Entity("FoodiApp.Models.FoodItem", b =>
                {
                    b.Property<int>("FoodItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodItemId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodCategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvaliabe")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("FoodItemId");

                    b.HasIndex("FoodCategoryId");

                    b.ToTable("FoodItems");

                    b.HasData(
                        new
                        {
                            FoodItemId = 1,
                            Description = "a crisp exterior and soft, airy interior",
                            FoodCategoryId = 1,
                            IsAvaliabe = true,
                            Name = "Bankcake",
                            Price = 2.0
                        },
                        new
                        {
                            FoodItemId = 2,
                            Description = "cooked, mashed chickpeas blended with tahini, lemon juice",
                            FoodCategoryId = 1,
                            IsAvaliabe = true,
                            Name = "hommus",
                            Price = 1.25
                        },
                        new
                        {
                            FoodItemId = 3,
                            Description = "a rice dish Serve with chicken and salad ",
                            FoodCategoryId = 2,
                            IsAvaliabe = true,
                            Name = "Kabsa",
                            Price = 7.0
                        },
                        new
                        {
                            FoodItemId = 4,
                            Description = "A small stuffy cake ",
                            FoodCategoryId = 3,
                            IsAvaliabe = false,
                            Name = "CupCake",
                            Price = 7.0
                        });
                });

            modelBuilder.Entity("FoodiApp.Models.FoodItem", b =>
                {
                    b.HasOne("FoodiApp.Models.FoodCategory", "foodCategory")
                        .WithMany("foodItems")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("foodCategory");
                });

            modelBuilder.Entity("FoodiApp.Models.FoodCategory", b =>
                {
                    b.Navigation("foodItems");
                });
#pragma warning restore 612, 618
        }
    }
}
