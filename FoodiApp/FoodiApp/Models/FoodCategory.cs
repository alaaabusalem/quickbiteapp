namespace FoodiApp.Models
{
	public class FoodCategory
	{

		public int FoodCategoryId { get; set; }
		public string Name { get; set; }

		//NP

		public List<FoodItem> foodItems { get; set; }

	}
}
