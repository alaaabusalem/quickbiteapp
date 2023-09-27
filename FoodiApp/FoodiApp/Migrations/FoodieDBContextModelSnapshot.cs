﻿// <auto-generated />
using System;
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
                            ConcurrencyStamp = "89b2e4f3-832e-4054-8619-eb0c99a219a8",
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEE9fK97ZwIAuu2Et0bEtB/vMcrJLnHYSpDSgDrt2Xz7e3lzRaqttLX65v4eJYpsPyw==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dd963ef8-421a-45be-84e1-c78af9d1e196",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("FoodiApp.Models.CartItem", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.Property<int>("FoodItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartId", "FoodItemId");

                    b.HasIndex("FoodItemId");

                    b.ToTable("CartItems");
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

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

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
                            ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/ScrambledEggs.jpg",
                            IsAvaliabe = true,
                            Name = "Scrambled Eggs",
                            Price = 5.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 2,
                            Description = "Stack of fluffy pancakes with syrup",
                            FoodCategoryId = 1,
                            ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/Pancake.jpg",
                            IsAvaliabe = true,
                            Name = "Pancakes",
                            Price = 7.4900000000000002
                        },
                        new
                        {
                            FoodItemId = 3,
                            Description = "Scrambled eggs, bacon, and cheese wrapped in a tortilla",
                            FoodCategoryId = 1,
                            ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/ClassicBreakfastBurrito.jpg",
                            IsAvaliabe = true,
                            Name = "Classic Breakfast Burrito",
                            Price = 8.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 4,
                            Description = "Chilled coffee served with ice",
                            FoodCategoryId = 2,
                            ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/IcedCoffee.jpg",
                            IsAvaliabe = true,
                            Name = "Iced Coffee",
                            Price = 3.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 5,
                            Description = "Blended fresh fruit with yogurt or juice",
                            FoodCategoryId = 2,
                            ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/FruitSmoothie.jpg",
                            IsAvaliabe = true,
                            Name = "Fruit Smoothie",
                            Price = 4.4900000000000002
                        },
                        new
                        {
                            FoodItemId = 6,
                            Description = "Rich and creamy hot chocolate",
                            FoodCategoryId = 2,
                            ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/HotChocolate.jpg",
                            IsAvaliabe = true,
                            Name = "Hot Chocolate",
                            Price = 3.4900000000000002
                        },
                        new
                        {
                            FoodItemId = 7,
                            Description = "Juicy grilled shrimp with garlic butter",
                            FoodCategoryId = 3,
                            ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/GrilledShrimp.jpg",
                            IsAvaliabe = true,
                            Name = "Grilled Shrimp",
                            Price = 12.99
                        },
                        new
                        {
                            FoodItemId = 8,
                            Description = "Creamy lobster soup with a hint of sherry",
                            FoodCategoryId = 3,
                            ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/LobsterBisque.jpg",
                            IsAvaliabe = true,
                            Name = "Lobster Bisque",
                            Price = 9.9900000000000002
                        },
                        new
                        {
                            FoodItemId = 9,
                            Description = "Assortment of seafood including shrimp, crab, and mussels",
                            FoodCategoryId = 3,
                            ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/SeafoodPlatter.jpg",
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
                        });
                });

            modelBuilder.Entity("FoodiApp.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeliverd")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("sessionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodiApp.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("FoodItemId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "FoodItemId");

                    b.HasIndex("FoodItemId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("FoodiApp.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartId"));

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("ShoppingCarts");
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
                            Id = "client",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        },
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

            modelBuilder.Entity("FoodiApp.Models.CartItem", b =>
                {
                    b.HasOne("FoodiApp.Models.FoodItem", "foodItem")
                        .WithMany("cartItems")
                        .HasForeignKey("FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodiApp.Models.ShoppingCart", "shoppingCart")
                        .WithMany("cartItems")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("foodItem");

                    b.Navigation("shoppingCart");
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

            modelBuilder.Entity("FoodiApp.Models.Order", b =>
                {
                    b.HasOne("FoodiApp.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodiApp.Models.OrderItem", b =>
                {
                    b.HasOne("FoodiApp.Models.FoodItem", "foodItem")
                        .WithMany("orderItems")
                        .HasForeignKey("FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodiApp.Models.Order", "order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("foodItem");

                    b.Navigation("order");
                });

            modelBuilder.Entity("FoodiApp.Models.ShoppingCart", b =>
                {
                    b.HasOne("FoodiApp.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("shoppingCart")
                        .HasForeignKey("FoodiApp.Models.ShoppingCart", "UserId");

                    b.Navigation("ApplicationUser");
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

            modelBuilder.Entity("FoodiApp.Models.ApplicationUser", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("shoppingCart");
                });

            modelBuilder.Entity("FoodiApp.Models.FoodCategory", b =>
                {
                    b.Navigation("foodItems");
                });

            modelBuilder.Entity("FoodiApp.Models.FoodItem", b =>
                {
                    b.Navigation("cartItems");

                    b.Navigation("orderItems");
                });

            modelBuilder.Entity("FoodiApp.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FoodiApp.Models.ShoppingCart", b =>
                {
                    b.Navigation("cartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
