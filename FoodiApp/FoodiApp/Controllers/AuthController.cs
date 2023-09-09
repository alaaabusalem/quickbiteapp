using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodiApp.Controllers
{
	public class AuthController : Controller
	{
		private readonly IUser _context;

        public AuthController(IUser context)
        {
            _context= context;
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
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginDto loginDto)
		{
			var user =await _context.Authenticate(loginDto.UserName, loginDto.Password);

				return RedirectToAction("Index", "Home");

		}
		public IActionResult Login()
		{
			return View();
		}
	}
}
