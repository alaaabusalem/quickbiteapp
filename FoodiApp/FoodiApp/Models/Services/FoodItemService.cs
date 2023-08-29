using FoodiApp.Data;
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
        public  IEnumerable<FoodItem> GetAllFoodItems()
        {
            var foodItems=  _context.FoodItems;
            return foodItems;
        }

        public IEnumerable<FoodItem> GetFoodItem(int categoryId)
        {
            var foodItem =  _context.FoodItems.Where(fi => fi.FoodCategoryId == categoryId);
            return foodItem;
        }

        public FoodItem  GetFoodItemDetails(int foodItemId)
        {
            var FIDetails = _context.FoodItems.FirstOrDefault(fid => fid.FoodItemId == foodItemId);
            return FIDetails;
        }
    }
}
