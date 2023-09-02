using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodiApp.Migrations
{
    /// <inheritdoc />
    public partial class AllDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 1,
                column: "Name",
                value: "Breakfast All Day");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 2,
                column: "Name",
                value: "Beverages and Drinks");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 3,
                column: "Name",
                value: "Seafood");

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "Name" },
                values: new object[,]
                {
                    { 4, "Pizza" },
                    { 5, "Pasta" },
                    { 6, "Desserts and Sweets" },
                    { 7, "Sides" },
                    { 8, "Soups" }
                });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Fluffy scrambled eggs served with toast", "Scrambled Eggs", 5.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Stack of fluffy pancakes with syrup", "Pancakes", 7.4900000000000002 });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 3,
                columns: new[] { "Description", "FoodCategoryId", "Name", "Price" },
                values: new object[] { "Scrambled eggs, bacon, and cheese wrapped in a tortilla", 1, "Classic Breakfast Burrito", 8.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 4,
                columns: new[] { "Description", "FoodCategoryId", "IsAvaliabe", "Name", "Price" },
                values: new object[] { "Chilled coffee served with ice", 2, true, "Iced Coffee", 3.9900000000000002 });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemId", "Description", "FoodCategoryId", "IsAvaliabe", "Name", "Price" },
                values: new object[,]
                {
                    { 5, "Blended fresh fruit with yogurt or juice", 2, true, "Fruit Smoothie", 4.4900000000000002 },
                    { 6, "Rich and creamy hot chocolate", 2, true, "Hot Chocolate", 3.4900000000000002 },
                    { 7, "Juicy grilled shrimp with garlic butter", 3, true, "Grilled Shrimp", 12.99 },
                    { 8, "Creamy lobster soup with a hint of sherry", 3, true, "Lobster Bisque", 9.9900000000000002 },
                    { 9, "Assortment of seafood including shrimp, crab, and mussels", 3, true, "Seafood Platter", 22.989999999999998 },
                    { 10, "Classic pizza with tomato, mozzarella, and basil", 4, true, "Margherita Pizza", 11.99 },
                    { 11, "Pizza topped with pepperoni and melted cheese", 4, true, "Pepperoni Pizza", 13.99 },
                    { 12, "Pizza with ham, pineapple, and tomato sauce", 4, true, "Hawaiian Pizza", 12.49 },
                    { 13, "Spaghetti with eggs, cheese, pancetta, and black pepper", 5, true, "Spaghetti Carbonara", 14.99 },
                    { 14, "Creamy fettuccine pasta with parmesan cheese", 5, true, "Fettuccine Alfredo", 13.49 },
                    { 15, "Homemade ravioli stuffed with lobster meat and served in a creamy sauce", 5, true, "Lobster Ravioli", 18.989999999999998 },
                    { 16, "Penne pasta with a spicy tomato sauce", 5, true, "Penne Arrabbiata", 11.99 },
                    { 17, "Melted chocolate served with fruits and marshmallows for dipping", 6, true, "Chocolate Fondue", 9.9900000000000002 },
                    { 18, "Classic Italian dessert made with coffee and mascarpone cheese", 6, true, "Tiramisu", 7.9900000000000002 },
                    { 19, "Creamy cheesecake with a graham cracker crust", 6, true, "New York Cheesecake", 8.4900000000000002 },
                    { 20, "Refreshing fruit sorbet with assorted flavors", 6, true, "Fruit Sorbet", 6.9900000000000002 },
                    { 21, "Creamy mashed potatoes with roasted garlic", 7, true, "Garlic Mashed Potatoes", 4.9900000000000002 },
                    { 22, "Assorted vegetables roasted to perfection", 7, true, "Roasted Vegetables", 5.4900000000000002 },
                    { 23, "Crispy French fries drizzled with truffle oil", 7, true, "Truffle Fries", 6.9900000000000002 },
                    { 24, "Spinach cooked in a creamy sauce with garlic and parmesan", 7, true, "Creamed Spinach", 5.9900000000000002 },
                    { 25, "Classic chicken noodle soup with vegetables", 8, true, "Chicken Noodle Soup", 6.4900000000000002 },
                    { 26, "Creamy tomato soup with fresh basil", 8, true, "Tomato Basil Soup", 5.9900000000000002 },
                    { 27, "Rich and creamy clam chowder with bacon", 8, true, "Clam Chowder", 7.4900000000000002 },
                    { 28, "Hearty vegetable minestrone soup with pasta", 8, true, "Vegetable Minestrone", 5.9900000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 1,
                column: "Name",
                value: "Breakfast");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 2,
                column: "Name",
                value: "Lunch");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 3,
                column: "Name",
                value: "FastFood");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "a crisp exterior and soft, airy interior", "Bankcake", 2.0 });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "cooked, mashed chickpeas blended with tahini, lemon juice", "hommus", 1.25 });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 3,
                columns: new[] { "Description", "FoodCategoryId", "Name", "Price" },
                values: new object[] { "a rice dish Serve with chicken and salad ", 2, "Kabsa", 7.0 });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 4,
                columns: new[] { "Description", "FoodCategoryId", "IsAvaliabe", "Name", "Price" },
                values: new object[] { "A small stuffy cake ", 3, false, "CupCake", 7.0 });
        }
    }
}
