using FoodiApp.Models;
using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodiApp.Controllers
{
	public class FoodItemController : Controller
	{
		private readonly IFoodItems _context;
		private readonly IFoodCategory _FoodCategory;

		public FoodItemController(IFoodItems context, IFoodCategory foodCategory)
		{
			_context = context;
			_FoodCategory = foodCategory;
		}
		public IActionResult Index()
		{
			var foodItems = _context.GetAllFoodItems();
			return View(foodItems);

		}
		public IActionResult Details(int id)
		{
			var foodItem = _context.GetFoodItem(id);
			return View(foodItem);

		}
		public IActionResult ItemDetails(int id)
		{

			var foodItem = _context.GetFoodItemDetails(id);
			return View(foodItem);
		}

		public async Task<IActionResult> Creat()
		{
			ViewBag.Categories = await _FoodCategory.GetFoodCategories();
			CreatFoodItemDTO creatFoodItemDTO = new CreatFoodItemDTO();

			return View(creatFoodItemDTO);
		}

		[HttpPost]
		public async Task<IActionResult> Creat(CreatFoodItemDTO creatFoodItemDTO)
		{
			var foodItem = await _context.Create(creatFoodItemDTO);
			return RedirectToAction("Details", new { id = creatFoodItemDTO.FoodCategoryId });

		}


		public async Task<IActionResult> Delet(int foodItemId, int categoryId)
		{
			await _context.Delete(foodItemId);
			return RedirectToAction("Details", new { id = categoryId });
		}

	}
}
