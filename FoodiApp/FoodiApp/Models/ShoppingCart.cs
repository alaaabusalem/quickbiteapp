namespace FoodiApp.Models
{
	public class ShoppingCart
	{
		public int ShoppingCartId { get; set; }

		//PF
		public string? UserId { get; set; }

		//NP

		public ApplicationUser? ApplicationUser { get; }
		public List<CartItem>? cartItems { get; set; }
	}
}
