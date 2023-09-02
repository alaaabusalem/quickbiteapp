using FoodiApp.Models.DTOs;

namespace FoodiApp.Models.Interfaces
{
	public interface IFoodItems
	{
		Task<CreatFoodItemDTO> Create(CreatFoodItemDTO creatFoodItemDTO);
		Task<CreatFoodItemDTO> Update(CreatFoodItemDTO creatFoodItemDTO);

		IEnumerable<FoodItem> GetAllFoodItems();

		IEnumerable<FoodItem> GetFoodItem(int categoryId);

		Task<FoodItem> GetFoodItemDetails(int foodItemId);
		Task Delete(int foodItemId);
	}
}
