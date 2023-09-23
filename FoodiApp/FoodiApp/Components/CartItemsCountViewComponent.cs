using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FoodiApp.Components
{
	public class CartItemsCountViewComponent: ViewComponent
	{
        private readonly IShoppingCart _shoppingCart;  
        public CartItemsCountViewComponent(IShoppingCart shoppingCart)
        {
            _shoppingCart=shoppingCart;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
			var claimsIdentity = User.Identity as ClaimsIdentity;
			if (claimsIdentity != null)
			{
				var userIdClaim = claimsIdentity.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
				if (userIdClaim != null)
				{
					var userIdValue = userIdClaim.Value;
					// Use the userIdValue as needed

					var items = await _shoppingCart.GetShoppingCartItems(userIdValue);
					int count = 0;
					foreach(var item in items) {
						count=count+item.Quantity;
					}
					ViewBag.Count = count;
				}
			}
		

            return View();
        }
    }
}
