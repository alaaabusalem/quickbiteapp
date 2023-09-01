namespace FoodiApp.Models.DTOs
{
	public class FoodItemDTO
	{
	}

	public class CreatFoodItemDTO
	{
		public int FoodItemId { get; set; }

		// FK
		public int FoodCategoryId { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public bool IsAvaliabe { get; set; }

	}
}
