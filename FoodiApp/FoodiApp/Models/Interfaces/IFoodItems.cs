using FoodiApp.Models.DTOs;

namespace FoodiApp.Models.Interfaces
{
	public interface IFoodItems
	{
		Task<CreatFoodItemDTO> Create(CreatFoodItemDTO creatFoodItemDTO);

		IEnumerable<FoodItem> GetAllFoodItems();

		IEnumerable<FoodItem> GetFoodItem(int categoryId);

		FoodItem GetFoodItemDetails(int foodItemId);
	}
}
