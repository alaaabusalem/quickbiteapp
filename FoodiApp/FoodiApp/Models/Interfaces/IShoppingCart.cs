namespace FoodiApp.Models.Interfaces
{
	public interface IShoppingCart
	{
		Task<ShoppingCart> GetShoppingCartItems(String UserName);
		Task AddItemToShoppingCart(string userName,int FoodId);
	}
}
