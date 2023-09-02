using FoodiApp.Data;
using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace FoodiApp.Models.Services
{
	public class FoodItemService : IFoodItems
	{
		private readonly FoodieDBContext _context;

		public FoodItemService(FoodieDBContext context)
		{
			_context = context;
		}

		public async Task<CreatFoodItemDTO> Create(CreatFoodItemDTO creatFoodItemDTO)
		{
			var category = await _context.FoodCategories.FindAsync(creatFoodItemDTO.FoodCategoryId);
			if (category != null)
			{
				var foodItem = new FoodItem()
				{
					FoodCategoryId = creatFoodItemDTO.FoodCategoryId,
					Name = creatFoodItemDTO.Name,
					Description = creatFoodItemDTO.Description,
					Price = creatFoodItemDTO.Price,
					IsAvaliabe = creatFoodItemDTO.IsAvaliabe
				};
				await _context.AddAsync(foodItem);
				await _context.SaveChangesAsync();
				creatFoodItemDTO.FoodItemId = foodItem.FoodItemId;
				return creatFoodItemDTO;
			}
			return null;
		}

		public async Task Delete(int foodItemId)
		{
			var foodItem = await _context.FoodItems.FindAsync(foodItemId);
			if (foodItem != null)
			{
				_context.FoodItems.Remove(foodItem);
				await _context.SaveChangesAsync();
			}
		}

		public IEnumerable<FoodItem> GetAllFoodItems()
		{
			var foodItems = _context.FoodItems;
			return foodItems;
		}

		public IEnumerable<FoodItem> GetFoodItem(int categoryId)
		{
			var foodItem = _context.FoodItems.Where(fi => fi.FoodCategoryId == categoryId);
			return foodItem;
		}

		public FoodItem GetFoodItemDetails(int foodItemId)
		{
			var FIDetails = _context.FoodItems.Include(f => f.foodCategory).FirstOrDefault(fid => fid.FoodItemId == foodItemId);
			return FIDetails;
		}

	}
}
