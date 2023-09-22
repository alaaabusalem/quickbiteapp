using FoodiApp.Models;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FoodiApp.Controllers
{
	public class ShoppingCartsController : Controller
	{
		private readonly IShoppingCart _shoppingCart;
        public ShoppingCartsController(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        [Authorize(Roles = "Client")]

        public async Task<IActionResult> Index()
		{

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID
            var cartItems = await _shoppingCart.GetShoppingCartItems(userId);
            ViewBag.Total = _shoppingCart.GetTotal(cartItems);

			return View(cartItems);	
		}

        [Authorize(Roles = "Client")]

        public async Task<IActionResult> AddFoodItemToCart(int foodItemId)

        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID

            
             await _shoppingCart.AddItemToShoppingCart(userId, foodItemId);
           
            return RedirectToAction("Index","Menu");
        }
       
        [Authorize(Roles = "Client")]

        public async Task<IActionResult> IncrementCartIrem(int foodItemId)

		{
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID

           
			await _shoppingCart.AddItemToShoppingCart(userId, foodItemId);
               
			return RedirectToAction("Index");
		}
        [Authorize(Roles = "Client")]

        public async Task<IActionResult> DeleteCartItem( int foodItemId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID
            await _shoppingCart.DeleteCartItem(userId, foodItemId);

            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Client")]

        public async Task<IActionResult> DecrementCartItem(int foodItemId)
		{
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID
            await _shoppingCart.DecrementCartItem(userId, foodItemId);

			return RedirectToAction("Index");
		}



	}
}
