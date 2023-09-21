namespace FoodiApp.Models.Interfaces
{
	public interface IShoppingCart
	{
		Task<List<CartItem>> GetShoppingCartItems(String UserName);
		Task AddItemToShoppingCart(string userName,int FoodId);
		Task<ShoppingCart> GetshoppingCartId(String userName);
	}
}
