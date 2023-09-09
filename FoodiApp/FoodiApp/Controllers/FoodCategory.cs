using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodiApp.Controllers
{

	public class FoodCategory : Controller
	{
		private readonly IFoodCategory _foodCategory;

		public FoodCategory(IFoodCategory foodCategory)
		{
			_foodCategory = foodCategory;
		}
		public async Task<IActionResult> Index()
		{
			var foodCategories = await _foodCategory.GetFoodCategories();
			return View(foodCategories);

		}
		[Authorize(Roles = "Admin")]
		public IActionResult Delete(int id)
		{
			_foodCategory.Delete(id);
			return RedirectToAction("Index");

		}
		[Authorize(Roles = "Admin")]

		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		[Authorize(Roles = "Admin")]

		public IActionResult Create(CreatFoodCategoryDTO foodCategoryDto)
		{
			if (!ModelState.IsValid)
			{
				return View(foodCategoryDto);
			}

			_foodCategory.Create(foodCategoryDto);
			return RedirectToAction("Index");
		}
		[Authorize(Roles = "Admin")]

		public IActionResult Update(int id)
		{
			var fc = _foodCategory.GetFoodCategory(id);
			return View(fc);
		}
		[HttpPost]
		[Authorize(Roles = "Admin")]

		public IActionResult Update(CreatFoodCategoryDTO foodCategoryDto, int id)
		{
			if (!ModelState.IsValid)
			{
				return View(foodCategoryDto);
			}

			_foodCategory.Update(foodCategoryDto, id);
			return RedirectToAction("Index");
		}

	}
}
