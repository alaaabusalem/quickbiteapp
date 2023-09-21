using FoodiApp.Data;
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
		public async Task AddItemToShoppingCart(string userName,int FoodId)
		{

			var shoppingCart = await GetshoppingCartId(userName);

                if (shoppingCart != null)
				{
					var foodItem = await _DB.FoodItems.FindAsync(FoodId);
					if (foodItem != null)
					{
						var shoppingItem = await _DB.CartItems
							.FirstOrDefaultAsync(foodItem => foodItem.FoodItemId == FoodId && foodItem.ShoppingCartId == shoppingCart.ShoppingCartId);
						if (shoppingItem == null)
						{
							await _DB.CartItems.AddAsync(new CartItem
							{
								FoodItemId = FoodId,
								ShoppingCartId = shoppingCart.ShoppingCartId,
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

		public async Task<List<CartItem>> GetShoppingCartItems(String UserName)
		{
			var shoppingcart = await GetshoppingCartId(UserName);
			if (shoppingcart != null)
			{
			var CartItems = await  _DB.CartItems.Include(cartItem=> cartItem.foodItem).Where(cartitem=> cartitem.ShoppingCartId== shoppingcart.ShoppingCartId).ToListAsync();

				foreach (var cartItem in CartItems)
				{
					cartItem.foodItem = await _DB.FoodItems.FindAsync(cartItem.FoodItemId);
				}
				return CartItems;
			}
			
			return null;
		}
		public async Task <ShoppingCart> GetshoppingCartId(String userName)
		{
			var user = await _UserService.GetUser(userName);
			if (user != null)
			{
				var shoppingCart = await _DB.ShoppingCarts.Include(shoppingCart=>shoppingCart.cartItems)
					.FirstAsync(shoppingCart => shoppingCart.UserId == user.Id);
				
				return shoppingCart;
			}
			return null;
		}

    }
}
