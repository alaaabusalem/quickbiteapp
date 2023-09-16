using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodiApp.Migrations
{
    /// <inheritdoc />
    public partial class newSeeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 4);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52f927bc-e633-434a-b9f9-60b08d38046e", "AQAAAAIAAYagAAAAECq9M84FQdOqDnFX5r4ka7ZfNBGGXjJMAa7m+kMv4rH4mFGc2e8wgH8c/Aomo3YrTw==", "e1e24ecf-cd36-4229-97f4-df1064d02887" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16f0320b-aa49-4263-821a-404d7617074b", "AQAAAAIAAYagAAAAED1+z5YKUDposNP3jYbIcyaZ1SMOhwv7LPbz7mAiYC4swsr3suzNRgn+VAaItBEQNg==", "8f01b45d-e1fc-4dd5-ab80-67faa5fc04b2" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemId", "Description", "FoodCategoryId", "ImageUrl", "IsAvaliabe", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Fluffy scrambled eggs served with toast", 1, "https://foodiappstaticfile.blob.core.windows.net/images/ScrambledEggs.jpg", true, "Scrambled Eggs", 5.9900000000000002 },
                    { 2, "Stack of fluffy pancakes with syrup", 1, "https://foodiappstaticfile.blob.core.windows.net/images/Pancake.jpg", true, "Pancakes", 7.4900000000000002 },
                    { 3, "Scrambled eggs, bacon, and cheese wrapped in a tortilla", 1, "https://foodiappstaticfile.blob.core.windows.net/images/ClassicBreakfastBurrito.jpg", true, "Classic Breakfast Burrito", 8.9900000000000002 },
                    { 4, "Chilled coffee served with ice", 2, "https://foodiappstaticfile.blob.core.windows.net/images/IcedCoffee.jpg", true, "Iced Coffee", 3.9900000000000002 },
                    { 5, "Blended fresh fruit with yogurt or juice", 2, "https://foodiappstaticfile.blob.core.windows.net/images/FruitSmoothie.jpg", true, "Fruit Smoothie", 4.4900000000000002 },
                    { 6, "Rich and creamy hot chocolate", 2, "https://foodiappstaticfile.blob.core.windows.net/images/HotChocolate.jpg", true, "Hot Chocolate", 3.4900000000000002 },
                    { 7, "Juicy grilled shrimp with garlic butter", 3, "https://foodiappstaticfile.blob.core.windows.net/images/GrilledShrimp.jpg", true, "Grilled Shrimp", 12.99 },
                    { 8, "Creamy lobster soup with a hint of sherry", 3, "https://foodiappstaticfile.blob.core.windows.net/images/LobsterBisque.jpg", true, "Lobster Bisque", 9.9900000000000002 },
                    { 9, "Assortment of seafood including shrimp, crab, and mussels", 3, "https://foodiappstaticfile.blob.core.windows.net/images/SeafoodPlatter.jpg", true, "Seafood Platter", 22.989999999999998 },
                    { 10, "Classic pizza with tomato, mozzarella, and basil", 4, null, true, "Margherita Pizza", 11.99 },
                    { 11, "Pizza topped with pepperoni and melted cheese", 4, null, true, "Pepperoni Pizza", 13.99 },
                    { 12, "Pizza with ham, pineapple, and tomato sauce", 4, null, true, "Hawaiian Pizza", 12.49 },
                    { 13, "Spaghetti with eggs, cheese, pancetta, and black pepper", 5, null, true, "Spaghetti Carbonara", 14.99 },
                    { 14, "Creamy fettuccine pasta with parmesan cheese", 5, null, true, "Fettuccine Alfredo", 13.49 },
                    { 15, "Homemade ravioli stuffed with lobster meat and served in a creamy sauce", 5, null, true, "Lobster Ravioli", 18.989999999999998 },
                    { 16, "Penne pasta with a spicy tomato sauce", 5, null, true, "Penne Arrabbiata", 11.99 },
                    { 17, "Melted chocolate served with fruits and marshmallows for dipping", 6, null, true, "Chocolate Fondue", 9.9900000000000002 },
                    { 18, "Classic Italian dessert made with coffee and mascarpone cheese", 6, null, true, "Tiramisu", 7.9900000000000002 },
                    { 19, "Creamy cheesecake with a graham cracker crust", 6, null, true, "New York Cheesecake", 8.4900000000000002 },
                    { 20, "Refreshing fruit sorbet with assorted flavors", 6, null, true, "Fruit Sorbet", 6.9900000000000002 },
                    { 21, "Creamy mashed potatoes with roasted garlic", 7, null, true, "Garlic Mashed Potatoes", 4.9900000000000002 },
                    { 22, "Assorted vegetables roasted to perfection", 7, null, true, "Roasted Vegetables", 5.4900000000000002 },
                    { 23, "Crispy French fries drizzled with truffle oil", 7, null, true, "Truffle Fries", 6.9900000000000002 },
                    { 24, "Spinach cooked in a creamy sauce with garlic and parmesan", 7, null, true, "Creamed Spinach", 5.9900000000000002 },
                    { 25, "Classic chicken noodle soup with vegetables", 8, null, true, "Chicken Noodle Soup", 6.4900000000000002 },
                    { 26, "Creamy tomato soup with fresh basil", 8, null, true, "Tomato Basil Soup", 5.9900000000000002 },
                    { 27, "Rich and creamy clam chowder with bacon", 8, null, true, "Clam Chowder", 7.4900000000000002 },
                    { 28, "Hearty vegetable minestrone soup with pasta", 8, null, true, "Vegetable Minestrone", 5.9900000000000002 }
                });
        }
    }
}
