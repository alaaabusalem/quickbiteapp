using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace FoodiApp.Models.Services
{
	public class UserService : IUser
	{
		private UserManager<ApplicationUser> _userManager;

		private SignInManager<ApplicationUser> _signManager;



		public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signManager)
        {
            _userManager = userManager;
			_signManager = signManager;	
        }

        public async Task<UserDto> Authenticate(string UserName, string password)
		{
			var result = await _signManager.PasswordSignInAsync(UserName, password,true,false);
			if (result.Succeeded) 
			{
				var user = await _userManager.FindByNameAsync(UserName);
				return new UserDto()
				{

					UserName = user.UserName
				};

			}
			return null;


		}

		public async Task<UserDto> Register(RegisterUserDto registerUser)
		{
			var user = new ApplicationUser()
			{
				UserName = registerUser.UserName,
				Email = registerUser.Email,
				PhoneNumber = registerUser.Phone
			};
			var result = await _userManager.CreateAsync(user,registerUser.Password);

			if (result.Succeeded)
			{
				return new UserDto
				{
					UserName = user.UserName
				};
			}
			return null;

		}
	}
}
