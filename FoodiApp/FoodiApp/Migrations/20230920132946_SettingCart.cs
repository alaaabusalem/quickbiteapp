using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodiApp.Migrations
{
    /// <inheritdoc />
    public partial class SettingCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ShoppingCartId);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false),
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => new { x.ShoppingCartId, x.FoodItemId });
                    table.ForeignKey(
                        name: "FK_CartItems_FoodItems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "FoodItems",
                        principalColumn: "FoodItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "ShoppingCartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f9a327d-83de-4322-a878-81a828d5d754", "AQAAAAIAAYagAAAAEKmCwx3HuS2GglObQStnnx3ZRaaXiSU+Bcws5GU3rh3L/aRY4STi1QMME/8JDfTl0Q==", "d07b6ad1-bbdb-47d6-b236-8d3a80392870" });

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
                    { 11, "Pizza topped with pepperoni and melted cheese", 4, null, true, "Pepperoni Pizza", 13.99 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_FoodItemId",
                table: "CartItems",
                column: "FoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f00b3beb-d2ec-4755-96b6-db0d42a3e309", "AQAAAAIAAYagAAAAEPskJ1HZPt/aU2+whJJVkTsVD9wXRPlkc3eF1e99sL5fYsotRAJlxL4QUAaHd9PCSA==", "76a2eea6-9603-4af4-a005-188e67705bc6" });
        }
    }
}
