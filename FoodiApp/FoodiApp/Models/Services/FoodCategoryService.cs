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
		public Task<FoodCategoryDTO> Create(CreatFoodCategoryDTO creatFoodCategoryDTO)
		{
			throw new NotImplementedException();
		}

		public Task Delete(int foodCategoryId)
		{
			throw new NotImplementedException();
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

		public Task<FoodCategoryDTO> GetFoodCategory(int foodCategoryId)
		{
			throw new NotImplementedException();
		}

		public Task<FoodCategoryDTO> Update(CreatFoodCategoryDTO creatFoodCategoryDTO, int foodCategoryId)
		{
			throw new NotImplementedException();
		}
	}
}
