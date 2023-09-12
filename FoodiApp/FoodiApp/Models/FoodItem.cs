namespace FoodiApp.Models
{
	public class FoodItem
	{
		public int FoodItemId { get; set; }

		// FK
		public int FoodCategoryId { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public bool IsAvaliabe { get; set; }

		//NP
		public string? ImageUrl { get; set; }

		public FoodCategory? foodCategory { get; set; }
	}
}
