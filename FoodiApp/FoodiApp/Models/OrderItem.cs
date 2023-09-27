namespace FoodiApp.Models
{
	public class OrderItem
	{
		// PK CK
		public int OrderId { get; set; }
		public int FoodItemId { get; set; }
		public int Quantity { get; set; }
		public double Price { get; set; }

		//NP
		public Order? order { get; set; }
		public FoodItem? foodItem { get; set; }

	}
}
