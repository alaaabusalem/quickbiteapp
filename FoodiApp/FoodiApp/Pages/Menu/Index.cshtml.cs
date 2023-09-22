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
       // public MenuVm menuVm { get; set; }  
        public List<FoodCategory> foodCategories { get; set; }
        public IndexModel(IFoodCategory foodCategory)
        {
            _foodCategory = foodCategory;
            //menuVm = new MenuVm();
            foodCategories = new List<FoodCategory>();  
        }
        public async Task OnGet()
        {
		 foodCategories = await _foodCategory.GetMenu();
			

			 Page();
        }
    }

 
}
