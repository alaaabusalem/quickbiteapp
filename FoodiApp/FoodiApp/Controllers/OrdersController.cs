using FoodiApp.Models;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FoodiApp.Controllers
{
	public class OrdersController : Controller
	{
		private readonly IEmail emailService;
        private readonly IShoppingCart _shoppingCart;
        public OrdersController(IEmail emailservice, IShoppingCart shoppingCart)
        {
            emailService= emailservice;	
			_shoppingCart= shoppingCart;	
        }
        [Authorize(Roles = "Client")]

        public async Task<IActionResult> Index()
		{
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID
            await SendOrderEmail(userId);
                return RedirectToAction("Index", "ShoppingCarts");
        }

		public async Task SendOrderEmail(string userId)
		{

            var claimsIdentity = User.Identity as ClaimsIdentity;
            if (claimsIdentity != null)
            {
                var emailClaim = claimsIdentity.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email);
                if (emailClaim != null)
                {
                    var emailValue = emailClaim.Value;
                    string Textmsg = $"thank you {User.Identity.Name} for your order from our website QuickBites \r\n \r\n Quick Bites Team";
                    string subject = "Welcome";
                   await emailService.SendEmailAsync(emailValue, subject, Textmsg);

                    // summary of Client purchase
                    subject = "Sumarry to Your purchases";
                    Textmsg = "this is a sumarry for purchases: \r\n";
                    var cartItems = await _shoppingCart.GetShoppingCartItems(userId);
                    float totalprice = _shoppingCart.GetTotal(cartItems);
                    foreach (var item in cartItems)
                    {
                        Textmsg = Textmsg + $"Name: {item.foodItem.Name} => Price: {item.foodItem.Price}$ => Quantity: {item.Quantity} => subTotal: {item.foodItem.Price * item.Quantity} \r\n";
                    }
                    Textmsg = Textmsg + $" ===>>>> Total price :{totalprice}$ \r\n \r\n Quick Bites Team";
                    await emailService.SendEmailAsync(emailValue, subject, Textmsg);

                    ////// administrator
                    subject = "to Sale Department purchases";
                    await emailService.SendEmailAsync("alaa.abusalem94@hotmail.com", subject, $"Client {User.Identity.Name} \r\n" +Textmsg);

                    //warehouse
                    subject = "to warehouse Department  purchases";
                    await emailService.SendEmailAsync("alaa.abusalem94@hotmail.com", subject, $"Client {User.Identity.Name} \r\n" + Textmsg);


                }
            }


        }
    }
}
