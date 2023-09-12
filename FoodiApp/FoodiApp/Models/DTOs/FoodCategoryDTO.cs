using System.ComponentModel.DataAnnotations;

namespace FoodiApp.Models.DTOs
{
	public class FoodCategoryDTO
	{
		public int FoodCategoryId { get; set; }
		public string Name { get; set; }
	}

	public class CreatFoodCategoryDTO
	{
		[Required]

		public string Name { get; set; }
	}
}
