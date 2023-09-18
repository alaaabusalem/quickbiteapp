using FoodiApp.Models.DTOs;

namespace FoodiApp.Models.Interfaces
{
	public interface IFoodCategory
	{
		FoodCategory Create(CreatFoodCategoryDTO creatFoodCategoryDTO);

		Task<List<FoodCategoryDTO>> GetFoodCategories();
		FoodCategory GetFoodCategory(int foodCategoryId);
		CreatFoodCategoryDTO Update(CreatFoodCategoryDTO creatFoodCategoryDTO, int foodCategoryId);
		void Delete(int foodCategoryId);
		Task<List<FoodCategory>> GetMenu();

	}
}
