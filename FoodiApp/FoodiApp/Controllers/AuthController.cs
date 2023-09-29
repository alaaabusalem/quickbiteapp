using System.Security.Claims;
using FoodiApp.Models;
using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using FoodiApp.Models.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodiApp.Controllers
{
	public class AuthController : Controller
	{
		private readonly IUser _context;

		public AuthController(IUser context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SignUp(RegisterUserDto regUser)
		{
			await _context.Register(regUser);
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index", "Home");

			}
			return View(regUser);
		}
		public IActionResult SignUp()
		{
			RegisterUserDto regUser = new RegisterUserDto();
			return View(regUser);
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginDto loginDto)
		{
			var user = await _context.Authenticate(loginDto);
			if (user != null && loginDto.RememberMe)
			{
				string name = user.UserName;
				CookieOptions cookieOptions = new CookieOptions();
				cookieOptions.Expires = DateTimeOffset.UtcNow.AddDays(7);


				HttpContext.Response.Cookies.Append("name", name, cookieOptions);
			}
			return RedirectToAction("Index", "Home");

		}
		[HttpGet]
		public async Task<IActionResult> Login()
		{
			string name = HttpContext.Request.Cookies["name"];
			if (name != null)
			{
				var user = await _context.GetUser(name);
				if (user != null)
				{
					return RedirectToAction("Index", "Home");
				}
			}

			return View();
			//}
			//else
			//{
			//	return RedirectToAction("FoodCategory", "Index");

			//}

		}

		[HttpPost]
		public async Task<IActionResult> SignUpAdmin(RegisterUserDto regUser)
		{
			await _context.RegisterAdmin(regUser, this.ModelState);
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index", "Index");

			}
			return View(regUser);
		}
		public IActionResult SignUpAdmin()
		{
			RegisterUserDto regUser = new RegisterUserDto();
			return View(regUser);
		}
		[Authorize]
		public async Task<IActionResult> Logout()
		{
			await _context.Logout();
			HttpContext.Response.Cookies.Delete("name");
			return RedirectToAction("Index", "Home");
		}
        [Authorize(Roles = "Client")]
        public async Task<IActionResult> UserProfile()
        {
            var  userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID
            var user = await _context.GetUserById(userId);
            return View(user);

        }


        

     


    }
}
