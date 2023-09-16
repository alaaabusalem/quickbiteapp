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



            //			modelBuilder.Entity<FoodCategory>().HasData(
            //		   new FoodCategory { FoodCategoryId = 1, Name = "Breakfast All Day" },
            //		   new FoodCategory { FoodCategoryId = 2, Name = "Beverages and Drinks" },
            //		   new FoodCategory { FoodCategoryId = 3, Name = "Seafood" },
            //		   new FoodCategory { FoodCategoryId = 4, Name = "Pizza" },
            //		   new FoodCategory { FoodCategoryId = 5, Name = "Pasta" },
            //		   new FoodCategory { FoodCategoryId = 6, Name = "Desserts and Sweets" },
            //		   new FoodCategory { FoodCategoryId = 7, Name = "Sides" },
            //		   new FoodCategory { FoodCategoryId = 8, Name = "Soups" }
            //	   );
            //			modelBuilder.Entity<FoodItem>().HasData(
            //				new FoodItem
            //				{
            //					FoodItemId = 1,
            //					FoodCategoryId = 1,
            //					Name = "Scrambled Eggs",
            //					Description = "Fluffy scrambled eggs served with toast",
            //					Price = 5.99,
            //					IsAvaliabe = true,
            //					ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/ScrambledEggs.jpg"
            //				},
            //new FoodItem
            //{
            //	FoodItemId = 2,
            //	FoodCategoryId = 1,
            //	Name = "Pancakes",
            //	Description = "Stack of fluffy pancakes with syrup",
            //	Price = 7.49,
            //	IsAvaliabe = true,
            //	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/Pancake.jpg"
            //},
            //new FoodItem
            //{
            //	FoodItemId = 3,
            //	FoodCategoryId = 1,
            //	Name = "Classic Breakfast Burrito",
            //	Description = "Scrambled eggs, bacon, and cheese wrapped in a tortilla",
            //	Price = 8.99,
            //	IsAvaliabe = true,
            //	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/ClassicBreakfastBurrito.jpg"
            //},
            //new FoodItem
            //{
            //	FoodItemId = 4,
            //	FoodCategoryId = 2,
            //	Name = "Iced Coffee",
            //	Description = "Chilled coffee served with ice",
            //	Price = 3.99,
            //	IsAvaliabe = true,
            //	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/IcedCoffee.jpg"
            //},
            //new FoodItem
            //{
            //	FoodItemId = 5,
            //	FoodCategoryId = 2,
            //	Name = "Fruit Smoothie",
            //	Description = "Blended fresh fruit with yogurt or juice",
            //	Price = 4.49,
            //	IsAvaliabe = true,
            //	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/FruitSmoothie.jpg"
            //},
            //new FoodItem
            //{
            //	FoodItemId = 6,
            //	FoodCategoryId = 2,
            //	Name = "Hot Chocolate",
            //	Description = "Rich and creamy hot chocolate",
            //	Price = 3.49,
            //	IsAvaliabe = true,
            //	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/HotChocolate.jpg"
            //}, new FoodItem
            //{
            //	FoodItemId = 7,
            //	FoodCategoryId = 3,
            //	Name = "Grilled Shrimp",
            //	Description = "Juicy grilled shrimp with garlic butter",
            //	Price = 12.99,
            //	IsAvaliabe = true,
            //	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/GrilledShrimp.jpg"
            //},
            //new FoodItem
            //{
            //	FoodItemId = 8,
            //	FoodCategoryId = 3,
            //	Name = "Lobster Bisque",
            //	Description = "Creamy lobster soup with a hint of sherry",
            //	Price = 9.99,
            //	IsAvaliabe = true,
            //	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/LobsterBisque.jpg"
            //},
            //new FoodItem
            //{
            //	FoodItemId = 9,
            //	FoodCategoryId = 3,
            //	Name = "Seafood Platter",
            //	Description = "Assortment of seafood including shrimp, crab, and mussels",
            //	Price = 22.99,
            //	IsAvaliabe = true,
            //	ImageUrl = "https://foodiappstaticfile.blob.core.windows.net/images/SeafoodPlatter.jpg"
            //}, new FoodItem
            //{
            //	FoodItemId = 10,
            //	FoodCategoryId = 4,
            //	Name = "Margherita Pizza",
            //	Description = "Classic pizza with tomato, mozzarella, and basil",
            //	Price = 11.99,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 11,
            //	FoodCategoryId = 4,
            //	Name = "Pepperoni Pizza",
            //	Description = "Pizza topped with pepperoni and melted cheese",
            //	Price = 13.99,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 12,
            //	FoodCategoryId = 4,
            //	Name = "Hawaiian Pizza",
            //	Description = "Pizza with ham, pineapple, and tomato sauce",
            //	Price = 12.49,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 13,
            //	FoodCategoryId = 5,
            //	Name = "Spaghetti Carbonara",
            //	Description = "Spaghetti with eggs, cheese, pancetta, and black pepper",
            //	Price = 14.99,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 14,
            //	FoodCategoryId = 5,
            //	Name = "Fettuccine Alfredo",
            //	Description = "Creamy fettuccine pasta with parmesan cheese",
            //	Price = 13.49,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 15,
            //	FoodCategoryId = 5,
            //	Name = "Lobster Ravioli",
            //	Description = "Homemade ravioli stuffed with lobster meat and served in a creamy sauce",
            //	Price = 18.99,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 16,
            //	FoodCategoryId = 5,
            //	Name = "Penne Arrabbiata",
            //	Description = "Penne pasta with a spicy tomato sauce",
            //	Price = 11.99,
            //	IsAvaliabe = true
            //}, new FoodItem
            //{
            //	FoodItemId = 17,
            //	FoodCategoryId = 6,
            //	Name = "Chocolate Fondue",
            //	Description = "Melted chocolate served with fruits and marshmallows for dipping",
            //	Price = 9.99,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 18,
            //	FoodCategoryId = 6,
            //	Name = "Tiramisu",
            //	Description = "Classic Italian dessert made with coffee and mascarpone cheese",
            //	Price = 7.99,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 19,
            //	FoodCategoryId = 6,
            //	Name = "New York Cheesecake",
            //	Description = "Creamy cheesecake with a graham cracker crust",
            //	Price = 8.49,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 20,
            //	FoodCategoryId = 6,
            //	Name = "Fruit Sorbet",
            //	Description = "Refreshing fruit sorbet with assorted flavors",
            //	Price = 6.99,
            //	IsAvaliabe = true
            //}, new FoodItem
            //{
            //	FoodItemId = 21,
            //	FoodCategoryId = 7,
            //	Name = "Garlic Mashed Potatoes",
            //	Description = "Creamy mashed potatoes with roasted garlic",
            //	Price = 4.99,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 22,
            //	FoodCategoryId = 7,
            //	Name = "Roasted Vegetables",
            //	Description = "Assorted vegetables roasted to perfection",
            //	Price = 5.49,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 23,
            //	FoodCategoryId = 7,
            //	Name = "Truffle Fries",
            //	Description = "Crispy French fries drizzled with truffle oil",
            //	Price = 6.99,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 24,
            //	FoodCategoryId = 7,
            //	Name = "Creamed Spinach",
            //	Description = "Spinach cooked in a creamy sauce with garlic and parmesan",
            //	Price = 5.99,
            //	IsAvaliabe = true
            //}, new FoodItem
            //{
            //	FoodItemId = 25,
            //	FoodCategoryId = 8,
            //	Name = "Chicken Noodle Soup",
            //	Description = "Classic chicken noodle soup with vegetables",
            //	Price = 6.49,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 26,
            //	FoodCategoryId = 8,
            //	Name = "Tomato Basil Soup",
            //	Description = "Creamy tomato soup with fresh basil",
            //	Price = 5.99,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 27,
            //	FoodCategoryId = 8,
            //	Name = "Clam Chowder",
            //	Description = "Rich and creamy clam chowder with bacon",
            //	Price = 7.49,
            //	IsAvaliabe = true
            //},
            //new FoodItem
            //{
            //	FoodItemId = 28,
            //	FoodCategoryId = 8,
            //	Name = "Vegetable Minestrone",
            //	Description = "Hearty vegetable minestrone soup with pasta",
            //	Price = 5.99,
            //	IsAvaliabe = true
            //}







            //				);

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
	}
}
