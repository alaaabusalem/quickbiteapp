using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiApp.Migrations
{
    /// <inheritdoc />
    public partial class newItemAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemId", "Description", "FoodCategoryId", "IsAvaliabe", "Name", "Price" },
                values: new object[] { 4, "A small stuffy cake ", 3, false, "CupCake", 7.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 4);
        }
    }
}
