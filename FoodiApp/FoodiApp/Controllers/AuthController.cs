using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
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
				CookieOptions cookieOptions = new CookieOptions();

				cookieOptions.Expires = DateTime.Now.AddDays(7);

				HttpContext.Response.Cookies.Append("name", loginDto.UserName, cookieOptions);
			}
			return RedirectToAction("Index", "Home");

		}
		public IActionResult Login()
		{
			//string name = HttpContext.Request.Cookies["name"];
			//if (name != null)
			//{
			//	return RedirectToAction("Index", "Home");
			//}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SignUpAdmin(RegisterUserDto regUser)
		{
			await _context.RegisterAdmin(regUser, this.ModelState);
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index", "Home");

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
			return RedirectToAction("Index", "Home");
		}
	}
}
