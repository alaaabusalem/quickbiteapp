using FoodiApp.Models;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace FoodiApp.Pages.Menu
{
    public class IndexModel : PageModel
    {
        private readonly IFoodCategory _foodCategory;
        public MenuVm menuVm { get; set; }  
        //public List<FoodCategory> foodCategories { get; set; }
        public IndexModel(IFoodCategory foodCategory)
        {
            _foodCategory = foodCategory;
            menuVm = new MenuVm();
        }
        public async Task OnGet(string userName)
        {
			menuVm.foodCategories = await _foodCategory.GetMenu();
			menuVm.userName = userName; 

			 Page();
        }
    }

    public class MenuVm
    {
		public List<FoodCategory> foodCategories { get; set; }

		public string userName;
	}
}
