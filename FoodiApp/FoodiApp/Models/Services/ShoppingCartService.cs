using FoodiApp.Data;
using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace FoodiApp.Models.Services
{
	public class ShoppingCartService: IShoppingCart
	{
		private readonly FoodieDBContext _DB;
		private readonly IUser  _UserService;
		public ShoppingCartService(FoodieDBContext foodieDBContext, IUser userService)
		{
			_DB = foodieDBContext;
			_UserService = userService;
		}
		public async Task AddItemToShoppingCart(String userId , int FoodId)
		{


            var shoppingcart = await GetshoppingCartByUserId(userId);
            if (shoppingcart != null)
            {
                var foodItem = await _DB.FoodItems.FindAsync(FoodId);
					if (foodItem != null)
					{
						var shoppingItem = await _DB.CartItems
							.FirstOrDefaultAsync(foodItem => foodItem.FoodItemId == FoodId && foodItem.ShoppingCartId == shoppingcart.ShoppingCartId);
						if (shoppingItem == null)
						{
							await _DB.CartItems.AddAsync(new CartItem
							{
								FoodItemId = FoodId,
								ShoppingCartId = shoppingcart.ShoppingCartId,
								Quantity = 1
							});

						}
						else
						{
							shoppingItem.Quantity = shoppingItem.Quantity + 1;
						}
						await _DB.SaveChangesAsync();

					}
				}
			

		
		}
        public async Task<List<CartItem>> GetShoppingCartItems(string userId)
        {
            var shoppingcart = await GetshoppingCartByUserId(userId);
            if (shoppingcart != null)
            {
                var CartItems = await _DB.CartItems.Include(cartItem => cartItem.foodItem).Where(cartitem => cartitem.ShoppingCartId == shoppingcart.ShoppingCartId).ToListAsync();

                foreach (var cartItem in CartItems)
                {
                    cartItem.foodItem = await _DB.FoodItems.FindAsync(cartItem.FoodItemId);
                }
                return CartItems;
            }

            return null;
        }

        public async Task <ShoppingCart> GetshoppingCartByUserId(String userId)
		{
			
				var shoppingCart = await _DB.ShoppingCarts.Include(shoppingCart=>shoppingCart.cartItems)
					.FirstAsync(shoppingCart => shoppingCart.UserId == userId);
				
				return shoppingCart;
			
		}

		public float GetTotal(List<CartItem> cartItems)
		{
			if (cartItems != null)
			{
				float Total = 0;
				foreach (CartItem cartItem in cartItems)
				{
					Total = (float)(Total + (cartItem.Quantity * cartItem.foodItem.Price));

				}
				return Total;
			}
			return 0;
		}

		

        public async Task DeleteCartItem(string userId, int foodItemId)
        {
            var shoppingcart = await GetshoppingCartByUserId(userId);
            if (shoppingcart != null)
            {
                var cartItemToRemove = shoppingcart.cartItems.FirstOrDefault(ci => ci.FoodItemId == foodItemId);

                if (cartItemToRemove != null)
                {
                    _DB.CartItems.Remove(cartItemToRemove);
                    await _DB.SaveChangesAsync();
                }
            }
        }

		public async Task DecrementCartItem(string userId, int foodItemId)
		{
            var shoppingcart = await GetshoppingCartByUserId(userId);
            if (shoppingcart != null)
            {
                var cartItem = shoppingcart.cartItems.FirstOrDefault(ci => ci.FoodItemId == foodItemId);

				if (cartItem != null && cartItem.Quantity > 1)
				{
					cartItem.Quantity -= 1;
					await _DB.SaveChangesAsync(); 
				}
				else if (cartItem != null && cartItem.Quantity == 1)
				{
				
					await DeleteCartItem(userId, foodItemId);
				}
			}
		}

     
    }
}
