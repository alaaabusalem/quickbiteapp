using FoodiApp.Models.DTOs;

namespace FoodiApp.Models.Interfaces
{
	public interface IUser
	{
		Task<UserDto> Register(RegisterUserDto registerUser);

		Task<UserDto> Authenticate (string UserName,string password);
	}
}
