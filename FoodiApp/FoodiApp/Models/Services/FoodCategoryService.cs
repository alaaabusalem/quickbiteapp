using FoodiApp.Data;
using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodiApp.Models.Services
{
	public class FoodCategoryService : IFoodCategory
	{
		private readonly FoodieDBContext _DB;
		public FoodCategoryService(FoodieDBContext DB)
		{
			_DB = DB;
		}
		public FoodCategory Create(CreatFoodCategoryDTO creatFoodCategoryDTO)
		{
			var foodCategory = new FoodCategory()
			{
				Name = creatFoodCategoryDTO.Name,
			};
			_DB.FoodCategories.Add(foodCategory);
			_DB.SaveChanges();
			return foodCategory;
		}

		public void  Delete(int foodCategoryId)
		{
			var foodCategory = _DB.FoodCategories.Where(fc => fc.FoodCategoryId == foodCategoryId).FirstOrDefault();
			_DB.FoodCategories.Remove(foodCategory);
			_DB.SaveChanges();
		}

		public async Task<List<FoodCategoryDTO>> GetFoodCategories()
		{
			var foodCategory = await _DB.FoodCategories.Select(FC => new FoodCategoryDTO
			{
				FoodCategoryId = FC.FoodCategoryId,
				Name = FC.Name,
			}).ToListAsync();

			return foodCategory;


		}

		public FoodCategory GetFoodCategory(int foodCategoryId)
		{
			var foodCategory = _DB.FoodCategories.Where(fc => fc.FoodCategoryId == foodCategoryId).FirstOrDefault();

			
			return foodCategory;
		}

		public CreatFoodCategoryDTO Update(CreatFoodCategoryDTO creatFoodCategoryDTO, int foodCategoryId)
		{
			var foodCategory = _DB.FoodCategories.Where(fc => fc.FoodCategoryId == foodCategoryId).FirstOrDefault();

			foodCategory.Name = creatFoodCategoryDTO.Name;

			_DB.SaveChanges();
			return creatFoodCategoryDTO;
		}
	}
}
