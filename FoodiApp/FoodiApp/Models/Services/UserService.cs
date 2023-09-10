using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FoodiApp.Models.Services
{
	public class UserService : IUser
	{
		private UserManager<ApplicationUser> _userManager;

		private SignInManager<ApplicationUser> _signManager;
		private JwtTokenService tokenService;


		public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signManager, JwtTokenService tokenservice
)
		{
			_userManager = userManager;
			_signManager = signManager;
			tokenService = tokenservice;
		}

		public async Task<UserDto> Authenticate(LoginDto loginDto)
		{
			var result = await _signManager.PasswordSignInAsync(loginDto.UserName, loginDto.Password, true, false);
			if (result.Succeeded)
			{

				var user = await _userManager.FindByNameAsync(loginDto.UserName);
				return new UserDto()
				{

					UserName = user.UserName,
					Token = await tokenService.GetToken(user, System.TimeSpan.FromMinutes(60))
				};

			}
			return null;


		}

		public async Task Logout()
		{
			await _signManager.SignOutAsync();
		}

		public async Task<UserDto> Register(RegisterUserDto registerUser)
		{
			var user = new ApplicationUser()
			{
				UserName = registerUser.Name,
				Email = registerUser.Email,
				PhoneNumber = registerUser.Phone
			};
			var result = await _userManager.CreateAsync(user, registerUser.Password);

			if (result.Succeeded)
			{
				string Role = "client";
				await _userManager.AddToRoleAsync(user, Role);
				return new UserDto
				{
					UserName = user.UserName
				};
			}
			return null;

		}
		public async Task<UserDto> RegisterAdmin(RegisterUserDto registerUser, ModelStateDictionary modelState)
		{
			var user = new ApplicationUser()
			{
				UserName = registerUser.Name,
				Email = registerUser.Email,
				PhoneNumber = registerUser.Phone
			};
			var result = await _userManager.CreateAsync(user, registerUser.Password);

			if (result.Succeeded)
			{
				string Role = "admin";
				await _userManager.AddToRoleAsync(user, Role);
				return new UserDto
				{
					UserName = user.UserName
				};
			}
			foreach (var error in result.Errors)
			{
				var errorKey = error.Code.Contains("Password") ? nameof(registerUser.Password) :
					error.Code.Contains("Name") ? nameof(registerUser.Name) :
					 error.Code.Contains("Email") ? nameof(registerUser.Email) :
					 "";

				modelState.AddModelError(errorKey, error.Description);
			}
			return null;

		}
	}
}
