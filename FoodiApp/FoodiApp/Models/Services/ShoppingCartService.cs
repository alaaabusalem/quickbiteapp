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
			var user = await _UserService.GetUser(userName);
			if (user != null)
			{
				var shoppingCart = await _DB.ShoppingCarts.FirstAsync(shoppingCart=> shoppingCart.UserId==user.Id);
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
						_DB.SaveChanges();

					}
				}
			}

		
		}

		public async Task<ShoppingCart> GetShoppingCartItems(String UserName)
		{
			var user = await _UserService.GetUser(UserName);
			if (user != null)
			{
			var Cart = _DB.ShoppingCarts.Include(Cart => Cart.cartItems).FirstOrDefault(cart => cart.UserId == user.Id);
			}
			
			return null;
		}


	}
}
