﻿// <auto-generated />
using System;
using FoodiApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodiApp.Migrations
{
    [DbContext(typeof(FoodieDBContext))]
    [Migration("20230909155739_SeedAdmin")]
    partial class SeedAdmin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodiApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "96892940-458b-482c-bf10-8826e958f6aa",
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEDHkzkPAuyHN6zYb+lbPwy3Rjei0WZX6Mn75kWs5JKGBRTW88fPBS5810xrNoKdNOA==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eebb61eb-cf72-4214-9e64-a3ae3d3442ee",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

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
                            Name = "Breakfast All Day"
                        },
                        new
                        {
                            FoodCategoryId = 2,
                            Name = "Beverages and Drinks"
                        },
                        new
                        {
                            FoodCategoryId = 3,
                            Name = "Seafood"
                        },
                        new
                        {
                            FoodCategoryId = 4,
                            Name = "Pizza"
                        },
                        new
                        {
                            FoodCategoryId = 5,
                            Name = "Pasta"
                        },
                        new
                        {
                            FoodCategoryId = 6,
                            Name = "Desserts and Sweets"
                        },
                        new
                        {
                            FoodCategoryId = 7,
                            Name = "Sides"
                        },
                        new
                        {
                            FoodCategoryId = 8,
                            Name = "Soups"
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
                            Description = "Fluffy scrambled eggs served with toast",
                            FoodCategoryId = 1,
                            IsAvaliabe = true,
                            Name = "Scrambled Eggs",
                            Price = 5.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 2,
                            Description = "Stack of fluffy pancakes with syrup",
                            FoodCategoryId = 1,
                            IsAvaliabe = true,
                            Name = "Pancakes",
                            Price = 7.4900000000000002
                        },
                        new
                        {
                            FoodItemId = 3,
                            Description = "Scrambled eggs, bacon, and cheese wrapped in a tortilla",
                            FoodCategoryId = 1,
                            IsAvaliabe = true,
                            Name = "Classic Breakfast Burrito",
                            Price = 8.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 4,
                            Description = "Chilled coffee served with ice",
                            FoodCategoryId = 2,
                            IsAvaliabe = true,
                            Name = "Iced Coffee",
                            Price = 3.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 5,
                            Description = "Blended fresh fruit with yogurt or juice",
                            FoodCategoryId = 2,
                            IsAvaliabe = true,
                            Name = "Fruit Smoothie",
                            Price = 4.4900000000000002
                        },
                        new
                        {
                            FoodItemId = 6,
                            Description = "Rich and creamy hot chocolate",
                            FoodCategoryId = 2,
                            IsAvaliabe = true,
                            Name = "Hot Chocolate",
                            Price = 3.4900000000000002
                        },
                        new
                        {
                            FoodItemId = 7,
                            Description = "Juicy grilled shrimp with garlic butter",
                            FoodCategoryId = 3,
                            IsAvaliabe = true,
                            Name = "Grilled Shrimp",
                            Price = 12.99
                        },
                        new
                        {
                            FoodItemId = 8,
                            Description = "Creamy lobster soup with a hint of sherry",
                            FoodCategoryId = 3,
                            IsAvaliabe = true,
                            Name = "Lobster Bisque",
                            Price = 9.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 9,
                            Description = "Assortment of seafood including shrimp, crab, and mussels",
                            FoodCategoryId = 3,
                            IsAvaliabe = true,
                            Name = "Seafood Platter",
                            Price = 22.989999999999998
                        },
                        new
                        {
                            FoodItemId = 10,
                            Description = "Classic pizza with tomato, mozzarella, and basil",
                            FoodCategoryId = 4,
                            IsAvaliabe = true,
                            Name = "Margherita Pizza",
                            Price = 11.99
                        },
                        new
                        {
                            FoodItemId = 11,
                            Description = "Pizza topped with pepperoni and melted cheese",
                            FoodCategoryId = 4,
                            IsAvaliabe = true,
                            Name = "Pepperoni Pizza",
                            Price = 13.99
                        },
                        new
                        {
                            FoodItemId = 12,
                            Description = "Pizza with ham, pineapple, and tomato sauce",
                            FoodCategoryId = 4,
                            IsAvaliabe = true,
                            Name = "Hawaiian Pizza",
                            Price = 12.49
                        },
                        new
                        {
                            FoodItemId = 13,
                            Description = "Spaghetti with eggs, cheese, pancetta, and black pepper",
                            FoodCategoryId = 5,
                            IsAvaliabe = true,
                            Name = "Spaghetti Carbonara",
                            Price = 14.99
                        },
                        new
                        {
                            FoodItemId = 14,
                            Description = "Creamy fettuccine pasta with parmesan cheese",
                            FoodCategoryId = 5,
                            IsAvaliabe = true,
                            Name = "Fettuccine Alfredo",
                            Price = 13.49
                        },
                        new
                        {
                            FoodItemId = 15,
                            Description = "Homemade ravioli stuffed with lobster meat and served in a creamy sauce",
                            FoodCategoryId = 5,
                            IsAvaliabe = true,
                            Name = "Lobster Ravioli",
                            Price = 18.989999999999998
                        },
                        new
                        {
                            FoodItemId = 16,
                            Description = "Penne pasta with a spicy tomato sauce",
                            FoodCategoryId = 5,
                            IsAvaliabe = true,
                            Name = "Penne Arrabbiata",
                            Price = 11.99
                        },
                        new
                        {
                            FoodItemId = 17,
                            Description = "Melted chocolate served with fruits and marshmallows for dipping",
                            FoodCategoryId = 6,
                            IsAvaliabe = true,
                            Name = "Chocolate Fondue",
                            Price = 9.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 18,
                            Description = "Classic Italian dessert made with coffee and mascarpone cheese",
                            FoodCategoryId = 6,
                            IsAvaliabe = true,
                            Name = "Tiramisu",
                            Price = 7.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 19,
                            Description = "Creamy cheesecake with a graham cracker crust",
                            FoodCategoryId = 6,
                            IsAvaliabe = true,
                            Name = "New York Cheesecake",
                            Price = 8.4900000000000002
                        },
                        new
                        {
                            FoodItemId = 20,
                            Description = "Refreshing fruit sorbet with assorted flavors",
                            FoodCategoryId = 6,
                            IsAvaliabe = true,
                            Name = "Fruit Sorbet",
                            Price = 6.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 21,
                            Description = "Creamy mashed potatoes with roasted garlic",
                            FoodCategoryId = 7,
                            IsAvaliabe = true,
                            Name = "Garlic Mashed Potatoes",
                            Price = 4.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 22,
                            Description = "Assorted vegetables roasted to perfection",
                            FoodCategoryId = 7,
                            IsAvaliabe = true,
                            Name = "Roasted Vegetables",
                            Price = 5.4900000000000002
                        },
                        new
                        {
                            FoodItemId = 23,
                            Description = "Crispy French fries drizzled with truffle oil",
                            FoodCategoryId = 7,
                            IsAvaliabe = true,
                            Name = "Truffle Fries",
                            Price = 6.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 24,
                            Description = "Spinach cooked in a creamy sauce with garlic and parmesan",
                            FoodCategoryId = 7,
                            IsAvaliabe = true,
                            Name = "Creamed Spinach",
                            Price = 5.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 25,
                            Description = "Classic chicken noodle soup with vegetables",
                            FoodCategoryId = 8,
                            IsAvaliabe = true,
                            Name = "Chicken Noodle Soup",
                            Price = 6.4900000000000002
                        },
                        new
                        {
                            FoodItemId = 26,
                            Description = "Creamy tomato soup with fresh basil",
                            FoodCategoryId = 8,
                            IsAvaliabe = true,
                            Name = "Tomato Basil Soup",
                            Price = 5.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 27,
                            Description = "Rich and creamy clam chowder with bacon",
                            FoodCategoryId = 8,
                            IsAvaliabe = true,
                            Name = "Clam Chowder",
                            Price = 7.4900000000000002
                        },
                        new
                        {
                            FoodItemId = 28,
                            Description = "Hearty vegetable minestrone soup with pasta",
                            FoodCategoryId = 8,
                            IsAvaliabe = true,
                            Name = "Vegetable Minestrone",
                            Price = 5.9900000000000002
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "admin",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FoodiApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FoodiApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodiApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FoodiApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodiApp.Models.FoodCategory", b =>
                {
                    b.Navigation("foodItems");
                });
#pragma warning restore 612, 618
        }
    }
}
