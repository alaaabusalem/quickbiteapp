namespace FoodiApp.Models
{
	public class CartItem
	{
		//PK CK

		public int ShoppingCartId { get; set; }
		public int FoodItemId { get; set; }
		//
		public int Quantity { get; set; }

		//NP
		public ShoppingCart? shoppingCart { get; set; }
		public FoodItem? foodItem { get; set; }
	}
}
