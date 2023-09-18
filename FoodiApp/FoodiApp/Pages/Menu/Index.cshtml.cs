using FoodiApp.Models;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodiApp.Pages.Menu
{
    public class IndexModel : PageModel
    {
        private readonly IFoodCategory _foodCategory;
        public List<FoodCategory> foodCategories { get; set; }
        public IndexModel(IFoodCategory foodCategory)
        {
            _foodCategory = foodCategory;
        }
        public async Task OnGet()
        {
            foodCategories = await _foodCategory.GetMenu();
             Page();
        }
    }
}
