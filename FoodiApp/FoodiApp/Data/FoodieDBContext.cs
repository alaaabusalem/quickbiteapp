using FoodiApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodiApp.Data
{
	public class FoodieDBContext : DbContext
	{
		public FoodieDBContext(DbContextOptions options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<FoodCategory>().HasData(
		   new FoodCategory { FoodCategoryId = 1, Name = "Breakfast" },
		   new FoodCategory { FoodCategoryId = 2, Name = "Lunch" },
		   new FoodCategory { FoodCategoryId = 3, Name = "FastFood" }
		 );
			modelBuilder.Entity<FoodItem>().HasData(
	   new FoodItem
	   {
		   FoodItemId = 1,
		   FoodCategoryId = 1,
		   Name = "Bankcake",
		   Description = "a crisp exterior and soft, airy interior",
		   Price = 2,
		   IsAvaliabe = true,
	   },
	   new FoodItem
	   {
		   FoodItemId = 2,
		   FoodCategoryId = 1,
		   Name = "hommus",
		   Description = "cooked, mashed chickpeas blended with tahini, lemon juice",
		   Price = 1.25,
		   IsAvaliabe = true,
	   },
 new FoodItem
 {
	 FoodItemId = 3,
	 FoodCategoryId = 2,
	 Name = "Kabsa",
	 Description = "a rice dish Serve with chicken and salad ",
	 Price = 7,
	 IsAvaliabe = true,
 },
 new FoodItem
 {
     FoodItemId = 4,
     FoodCategoryId = 3,
     Name = "CupCake",
     Description = "A small stuffy cake ",
     Price = 7,
     IsAvaliabe = false,
 }
     );
		}

		public DbSet<FoodCategory> FoodCategories { get; set; }
		public DbSet<FoodItem> FoodItems { get; set; }
	}
}
