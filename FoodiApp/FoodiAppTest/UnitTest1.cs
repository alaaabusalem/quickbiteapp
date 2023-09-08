using FoodiApp.Models.DTOs;
using FoodiApp.Models.Services;

namespace FoodiAppTest
{
	public class UnitTest1 : MockDB

	{
		[Fact]
		public void Test_Create_and_Read_Category()
		{
			var category = CreateAndSaveFoodCategory();
			var categoryDTO = new CreatFoodCategoryDTO()
			{
				Name = category.Name
			};

			var service = new FoodCategoryService(_db);

			var result = service.Create(categoryDTO);

			Assert.Equal(category.Name, result.Name);


		}
		[Fact]
		public void Test_Update_FoodCategory()
		{
			var category = CreateAndSaveFoodCategory();
			var categoryDTO = new CreatFoodCategoryDTO()
			{
				Name = category.Name
			};

			var service = new FoodCategoryService(_db);

			var result = service.Create(categoryDTO);

			var categoryDtoUpdate = new CreatFoodCategoryDTO()
			{
				Name = "Updated Category"
			};

			var res2 = service.Update(categoryDtoUpdate, result.FoodCategoryId);

			Assert.Equal(categoryDtoUpdate.Name,res2.Name);

		}
		[Fact]
		public void Test_Delete_FoodCategory()
		{
			var category = CreateAndSaveFoodCategory();
			var categoryDTO = new CreatFoodCategoryDTO()
			{
				Name = category.Name
			};

			var service = new FoodCategoryService(_db);

			var result = service.Create(categoryDTO);

			service.Delete(result.FoodCategoryId);

			var DeletedCategory = service.GetFoodCategory(result.FoodCategoryId);

			Assert.Null(DeletedCategory);

		}
	}
}