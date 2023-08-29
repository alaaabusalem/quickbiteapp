using FoodiApp.Models.DTOs;

namespace FoodiApp.Models.Interfaces
{
    public interface IFoodItems
    {
        IEnumerable<FoodItem> GetAllFoodItems();

        IEnumerable<FoodItem> GetFoodItem(int categoryId);

        FoodItem GetFoodItemDetails(int foodItemId);
    }
}
