using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FoodiApp.Controllers
{
	public class OrdersController : Controller
	{
		private readonly IEmail emailService;
        public OrdersController(IEmail emailservice)
        {
            emailService= emailservice;	
        }
        [Authorize(Roles = "Client")]

        public IActionResult Index()
		{
			var claimsIdentity = User.Identity as ClaimsIdentity;
			if (claimsIdentity != null)
			{
				var emailClaim = claimsIdentity.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email);
				if (emailClaim != null)
				{
					var emailValue = emailClaim.Value;
					string welcomeClient = $"thank you {User.Identity.Name} for your order from our website QuickBites";
					string subject = "Welcome";
					emailService.SendEmailAsync(emailValue, subject, welcomeClient);
					// Use the emailValue as needed
				}
			}
            return RedirectToAction("Index", "ShoppingCarts");
        }
    }
}
