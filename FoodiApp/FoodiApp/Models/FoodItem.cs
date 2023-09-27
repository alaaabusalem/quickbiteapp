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
		public string? ImageUrl { get; set; }

		//NP

		public FoodCategory? foodCategory { get; set; }
		public List<CartItem>? cartItems { get; set; }
		public List<OrderItem>? orderItems { get; set; }


	}
}
