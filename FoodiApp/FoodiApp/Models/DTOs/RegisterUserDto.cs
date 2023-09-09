using System.ComponentModel.DataAnnotations;

namespace FoodiApp.Models.DTOs
{
	public class RegisterUserDto
	{
		[Required]
		public string Name { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Compare(nameof(Password), ErrorMessage = "Passords Are Not Identical")]
		public string ConfirmPassword { get; set; }
		[Required]
		public string Phone { get; set; }
	}
}
