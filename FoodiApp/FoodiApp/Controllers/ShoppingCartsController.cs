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
			var cart = await _shoppingCart.GetShoppingCartItems(userName);
		    return View(cart);	
		}

        public async Task<IActionResult> AddFoodItemToCart(string userName,int foodItemId)
        {
             await _shoppingCart.AddItemToShoppingCart(userName, foodItemId);
            return RedirectToAction("Index");
        }
        public IActionResult test()
        {
            return View();
        }
    }
}
