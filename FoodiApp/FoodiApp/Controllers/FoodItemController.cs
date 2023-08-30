using FoodiApp.Models;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodiApp.Controllers
{
    public class FoodItemController : Controller
    {
        private readonly IFoodItems _context;

        public FoodItemController(IFoodItems context)
        {
            _context = context;
        }
        public  IActionResult Index()
        {
            var foodItems =  _context.GetAllFoodItems();
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

    }
}
