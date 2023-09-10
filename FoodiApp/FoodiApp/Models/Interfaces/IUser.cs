using System.Security.Claims;
using FoodiApp.Models.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Win32;

namespace FoodiApp.Models.Interfaces
{
	public interface IUser
	{
		Task<UserDto> Register(RegisterUserDto registerUser);

		Task<UserDto> RegisterAdmin(RegisterUserDto registerUser, ModelStateDictionary modelState);
		Task<UserDto> Authenticate(LoginDto loginDto);
		Task Logout();
		Task<UserDto> GetUser(string name);


	}
}
