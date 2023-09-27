using Microsoft.AspNetCore.Identity;

namespace FoodiApp.Models
{
	public class ApplicationUser : IdentityUser
	{
		//NP

		public ShoppingCart? shoppingCart { get; set; }
		public List<Order>? Orders { get; set; }

	}
}
