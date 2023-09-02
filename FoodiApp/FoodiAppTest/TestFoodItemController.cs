using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodiApp.Controllers;
using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using FoodiApp.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodiAppTest
{
	public class TestFoodItemController : MockDB
	{



		[Fact]
		public async void TestGetCreatFoodItemController()
		{
			var foodItemService = new FoodItemService(_db);
			var foodCategoryService = new FoodCategoryService(_db);
			FoodItemController foodItemController = new FoodItemController(foodItemService, foodCategoryService);
			//var creatFoodItemDTO = new CreatFoodItemDTO();
			var result = await foodItemController.Creat() as ViewResult;
			Assert.IsType<ViewResult>(result);

		}

		[Fact]
		public async void TestPostCreatFoodItemController()
		{
			var foodItemService = new FoodItemService(_db);
			var foodCategoryService = new FoodCategoryService(_db);
			FoodItemController foodItemController = new FoodItemController(foodItemService, foodCategoryService);
			var creatFoodItemDTO = new CreatFoodItemDTO()
			{
				FoodItemId = 0,
				FoodCategoryId = 1,
				Name = "testPostCreatFoodItem",
				Description = "testPostCreatFoodItem",
				Price = 30,
				IsAvaliabe = true,
			};
			var result = await foodItemController.Creat(creatFoodItemDTO) as RedirectToActionResult;
			Assert.IsType<RedirectToActionResult>(result);

		}

		[Fact]
		public async void TestGetUpdateFoodItemController()
		{
			var foodItemService = new FoodItemService(_db);
			var foodCategoryService = new FoodCategoryService(_db);
			FoodItemController foodItemController = new FoodItemController(foodItemService, foodCategoryService);
			//var creatFoodItemDTO = new CreatFoodItemDTO();
			var result = await foodItemController.Update(1) as ViewResult;
			Assert.IsType<ViewResult>(result);

		}

		[Fact]
		public async void TestPostUpdateFoodItemController()
		{
			var foodItemService = new FoodItemService(_db);
			var foodCategoryService = new FoodCategoryService(_db);
			FoodItemController foodItemController = new FoodItemController(foodItemService, foodCategoryService);
			var UpdateFoodItemDTO = new CreatFoodItemDTO()
			{
				FoodItemId = 1,
				FoodCategoryId = 1,
				Name = "testPostUpdateFoodItem",
				Description = "testPostUpdateFoodItem",
				Price = 30,
				IsAvaliabe = true,
			};
			var result = await foodItemController.Update(UpdateFoodItemDTO) as RedirectToActionResult;
			Assert.IsType<RedirectToActionResult>(result);
		}

		[Fact]
		public async void TestDeleteFoodItemController()
		{
			var foodItemService = new FoodItemService(_db);
			var foodCategoryService = new FoodCategoryService(_db);
			FoodItemController foodItemController = new FoodItemController(foodItemService, foodCategoryService);
			var result = await foodItemController.Delet(1, 1) as RedirectToActionResult;
			Assert.IsType<RedirectToActionResult>(result);

		}

		[Fact]
		public async void TestGetItemDetailsController()
		{
			var foodItemService = new FoodItemService(_db);
			var foodCategoryService = new FoodCategoryService(_db);
			FoodItemController foodItemController = new FoodItemController(foodItemService, foodCategoryService);
			//var creatFoodItemDTO = new CreatFoodItemDTO();
			var result = await foodItemController.ItemDetails(1) as ViewResult;
			Assert.IsType<ViewResult>(result);

		}
		[Fact]
		public async void TestGetDetailsController()
		{
			var foodItemService = new FoodItemService(_db);
			var foodCategoryService = new FoodCategoryService(_db);
			FoodItemController foodItemController = new FoodItemController(foodItemService, foodCategoryService);
			//var creatFoodItemDTO = new CreatFoodItemDTO();
			var result = foodItemController.Details(1) as ViewResult;
			Assert.IsType<ViewResult>(result);

		}
		[Fact]
		public async void TestGetIndexController()
		{
			var foodItemService = new FoodItemService(_db);
			var foodCategoryService = new FoodCategoryService(_db);
			FoodItemController foodItemController = new FoodItemController(foodItemService, foodCategoryService);
			//var creatFoodItemDTO = new CreatFoodItemDTO();
			var result = foodItemController.Index() as ViewResult;
			Assert.IsType<ViewResult>(result);

		}
	}
}
