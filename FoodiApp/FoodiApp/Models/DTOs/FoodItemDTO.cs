using System.ComponentModel.DataAnnotations;

namespace FoodiApp.Models.DTOs
{
	public class FoodItemDTO
	{
	}

	public class CreatFoodItemDTO
	{
		public int FoodItemId { get; set; }

		// FK
		public int FoodCategoryId { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]

		public string Description { get; set; }

		[Required]

		public double Price { get; set; }

		[Required]

		public bool IsAvaliabe { get; set; }


		public string? ImageUrl { get; set; }

		[Required]

		public IFormFile? ImageFile { get; set; }

	}
}
