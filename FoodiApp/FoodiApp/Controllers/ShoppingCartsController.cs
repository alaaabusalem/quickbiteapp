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
		    return View(cartItems);	
		}

        public async Task<IActionResult> AddFoodItemToCart(string userName,int foodItemId)
        {
             await _shoppingCart.AddItemToShoppingCart(userName, foodItemId);
           
            return RedirectToAction("Index","Menu" ,new {userName = userName});
        }
        public IActionResult test()
        {
            return View();
        }
    }
}
