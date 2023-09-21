using FoodiApp.Models;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodiApp.Controllers
{
	public class ShoppingCartsController : Controller
	{
		private readonly IShoppingCart _shoppingCart;
        public ShoppingCartsController(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        public async Task<IActionResult> Index(string userName)
		{
			var cartItems = await _shoppingCart.GetShoppingCartItems(userName);
            ViewBag.Total = _shoppingCart.GetTotal(cartItems);

			return View(cartItems);	
		}

        public async Task<IActionResult> AddFoodItemToCart(string userName,int foodItemId)

        {
            var shoppingCart = await _shoppingCart.GetshoppingCartByUserName(userName);
             await _shoppingCart.AddItemToShoppingCart(shoppingCart, foodItemId);
           
            return RedirectToAction("Index","Menu" ,new {userName = userName});
        }
        public IActionResult test()
        {
            return View();
        }
		public async Task<IActionResult> IncrementCartIrem(int ShoppingCartId, int foodItemId)

		{
			var shoppingCart = await _shoppingCart.GetshoppingCartByCartID(ShoppingCartId);
			await _shoppingCart.AddItemToShoppingCart(shoppingCart, foodItemId);
            var user= await _shoppingCart.GetUserByUserId(shoppingCart.UserId);    
			return RedirectToAction("Index", new { userName = user.UserName });
		}
        public async Task<IActionResult> DeleteCartItem(int shoppingCartId, int foodItemId)
        {
            await _shoppingCart.DeleteCartItem(shoppingCartId, foodItemId);
            var shoppingCart = await _shoppingCart.GetshoppingCartByCartID(shoppingCartId);
            var user = await _shoppingCart.GetUserByUserId(shoppingCart.UserId);

            return RedirectToAction("Index", new { userName = user.UserName });
        }
		public async Task<IActionResult> DecrementCartItem(int ShoppingCartId, int foodItemId)
		{
			await _shoppingCart.DecrementCartItem(ShoppingCartId, foodItemId);
			var shoppingCart = await _shoppingCart.GetshoppingCartByCartID(ShoppingCartId);
			var user = await _shoppingCart.GetUserByUserId(shoppingCart.UserId);

			return RedirectToAction("Index", new { userName = user.UserName });
		}



	}
}
