using FoodiApp.Models.DTOs;

namespace FoodiApp.Models.Interfaces
{
	public interface IFoodCategory
	{
		Task<FoodCategoryDTO> Create(CreatFoodCategoryDTO creatFoodCategoryDTO);

		Task<List<FoodCategoryDTO>> GetFoodCategories();
		Task<FoodCategoryDTO> GetFoodCategory(int foodCategoryId);
		Task<FoodCategoryDTO> Update(CreatFoodCategoryDTO creatFoodCategoryDTO, int foodCategoryId);
		Task Delete(int foodCategoryId);
	}
}
