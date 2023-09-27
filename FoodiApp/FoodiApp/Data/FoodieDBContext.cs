using FoodiApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodiApp.Data
{
	public class FoodieDBContext : IdentityDbContext<ApplicationUser>
	{
		public FoodieDBContext(DbContextOptions options) : base(options)
		{

		}




		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			base.OnModelCreating(modelBuilder);
			// setting the relation (1-1) ApplicationUser & ShoppingCart
			modelBuilder.Entity<CartItem>().HasKey(sc => new { sc.ShoppingCartId, sc.FoodItemId });

			modelBuilder.Entity<ApplicationUser>()
		   .HasOne<ShoppingCart>(user => user.shoppingCart)
		   .WithOne(shoppingCart => shoppingCart.ApplicationUser)
		   .HasForeignKey<ShoppingCart>(shoppingCart => shoppingCart.UserId);
            // Order user relation
			modelBuilder.Entity<ApplicationUser>()
	       .HasMany<Order>(user => user.Orders)
	       .WithOne(order => order.User)
	       .HasForeignKey(order => order.UserId);
			// orderItems
			modelBuilder.Entity<OrderItem>().HasKey(oi => new { oi.OrderId, oi.FoodItemId });


			modelBuilder.Entity<FoodCategory>().HasData(
                       new FoodCategory { FoodCategoryId = 1, Name = "Breakfast All Day" },
                       new FoodCategory { FoodCategoryId = 2, Name = "Beverages and Drinks" },
                       new FoodCategory { FoodCategoryId = 3, Name = "Seafood" },
                       new FoodCategory { FoodCategoryId = 4, Name = "Pizza" },
                       new FoodCategory { FoodCategoryId = 5, Name = "Pasta" },
                       new FoodCategory { FoodCategoryId = 6, Name = "Desserts and Sweets" },
                       new FoodCategory { FoodCategoryId = 7, Name = "Sides" },
                       new FoodCategory { FoodCategoryId = 8, Name = "Soups" }
                   );

            	
            			modelBuilder.Entity<FoodItem>().HasData(
            				new FoodItem
            				{
            					FoodItemId = 1,
            					FoodCategoryId = 1,
            					Name = "Scrambled Eggs",
            					Description = "Fluffy scrambled eggs served with toast",
            					Price = 5.99,
            					IsAvaliabe = true,
            			ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/ScrambledEggs.jpg"
            				},
            new FoodItem
            {
            	FoodItemId = 2,
            	FoodCategoryId = 1,
            	Name = "Pancakes",
            	Description = "Stack of fluffy pancakes with syrup",
            	Price = 7.49,
            	IsAvaliabe = true,
            	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/Pancake.jpg"
            },
            new FoodItem
            {
            	FoodItemId = 3,
            	FoodCategoryId = 1,
            	Name = "Classic Breakfast Burrito",
            	Description = "Scrambled eggs, bacon, and cheese wrapped in a tortilla",
            	Price = 8.99,
            	IsAvaliabe = true,
            	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/ClassicBreakfastBurrito.jpg"
            },
            new FoodItem
            {
            	FoodItemId = 4,
            	FoodCategoryId = 2,
            	Name = "Iced Coffee",
            	Description = "Chilled coffee served with ice",
            	Price = 3.99,
            	IsAvaliabe = true,
            	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/IcedCoffee.jpg"
            },
            new FoodItem
            {
            	FoodItemId = 5,
            	FoodCategoryId = 2,
            	Name = "Fruit Smoothie",
            	Description = "Blended fresh fruit with yogurt or juice",
            	Price = 4.49,
            	IsAvaliabe = true,
            	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/FruitSmoothie.jpg"
            },
            new FoodItem
            {
            	FoodItemId = 6,
            	FoodCategoryId = 2,
            	Name = "Hot Chocolate",
            Description = "Rich and creamy hot chocolate",
            Price = 3.49,
            IsAvaliabe = true,
            ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/HotChocolate.jpg"
            }, new FoodItem
            {
            	FoodItemId = 7,
            FoodCategoryId = 3,
            	Name = "Grilled Shrimp",
            	Description = "Juicy grilled shrimp with garlic butter",
            	Price = 12.99,
            	IsAvaliabe = true,
            	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/GrilledShrimp.jpg"
            },
            new FoodItem
            {
                FoodItemId = 8,
                FoodCategoryId = 3,
                Name = "Lobster Bisque",
                Description = "Creamy lobster soup with a hint of sherry",
                Price = 9.99,
                IsAvaliabe = true,
                ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/LobsterBisque.jpg"
            },
            new FoodItem
            {
            	FoodItemId = 9,
            	FoodCategoryId = 3,
            	Name = "Seafood Platter",
            	Description = "Assortment of seafood including shrimp, crab, and mussels",
            	Price = 22.99,
            	IsAvaliabe = true,
            	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/SeafoodPlatter.jpg"
            }, new FoodItem
            {
            	FoodItemId = 10,
            	FoodCategoryId = 4,
            	Name = "Margherita Pizza",
            	Description = "Classic pizza with tomato, mozzarella, and basil",
            	Price = 11.99,
            	IsAvaliabe = true
            },
            new FoodItem
            {
            	FoodItemId = 11,
            	FoodCategoryId = 4,
            	Name = "Pepperoni Pizza",
            	Description = "Pizza topped with pepperoni and melted cheese",
            	Price = 13.99,
            	IsAvaliabe = true
            }






            			);

            SeedRole(modelBuilder, "Client");
			SeedRole(modelBuilder, "Admin");

			var hasher = new PasswordHasher<ApplicationUser>();


			var admin = new ApplicationUser
			{
				Id = "1",
				UserName = "admin",
				NormalizedUserName = "ADMIN",
				Email = "admin@example.com",
				PhoneNumber = "1234567890",
				NormalizedEmail = "admin@EXAMPLE.COM",
				EmailConfirmed = true,
				LockoutEnabled = false
			};
			admin.PasswordHash = hasher.HashPassword(admin, "Admin@123");
			modelBuilder.Entity<ApplicationUser>().HasData(admin);
			modelBuilder.Entity<IdentityUserRole<string>>().HasData(
			new IdentityUserRole<string>
			{
				RoleId = "admin",
				UserId = admin.Id
			});



		}




		private int nextId = 1;
		private void SeedRole(ModelBuilder modelBuilder, string roleName, params string[] permissions)
		{
			var role = new IdentityRole
			{
				Id = roleName.ToLower(),
				Name = roleName,
				NormalizedName = roleName.ToUpper(),
				ConcurrencyStamp = Guid.Empty.ToString()
			};
			modelBuilder.Entity<IdentityRole>().HasData(role);

			var roleClaims = permissions.Select(permission =>
			new IdentityRoleClaim<string>
			{
				Id = nextId++,
				RoleId = role.Id,
				ClaimType = "permissions",
				ClaimValue = permission
			}).ToArray();
			modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(roleClaims);
		}


		public DbSet<FoodCategory> FoodCategories { get; set; }
		public DbSet<FoodItem> FoodItems { get; set; }
		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }


	}
}
