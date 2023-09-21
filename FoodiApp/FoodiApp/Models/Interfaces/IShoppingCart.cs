using FoodiApp.Models.DTOs;

namespace FoodiApp.Models.Interfaces
{
	public interface IShoppingCart
	{
		Task<List<CartItem>> GetShoppingCartItems(String UserName);
		Task AddItemToShoppingCart(ShoppingCart shoppingCart,int FoodId);
		Task<ShoppingCart> GetshoppingCartByUserName(String userName);
		 float GetTotal(List<CartItem> cartItems);
		Task<ShoppingCart> GetshoppingCartByCartID(int ShoppingCartId);
		  Task<UserDto> GetUserByUserId(String Id);
	}
}
