using FoodiApp.Models.DTOs;

namespace FoodiApp.Models.Interfaces
{
	public interface IShoppingCart
	{
        Task<List<CartItem>> GetShoppingCartItems(String userId);
		Task AddItemToShoppingCart(String userId, int FoodId);

		 Task<ShoppingCart> GetshoppingCartByUserId(String userId);

        float GetTotal(List<CartItem> cartItems);
		

        Task DeleteCartItem(string userId, int foodItemId);

        Task DecrementCartItem(string userId, int foodItemId);
		Task EmptyTheCart(string userId);

	}
}
