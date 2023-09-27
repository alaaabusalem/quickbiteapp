using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiApp.Migrations
{
    /// <inheritdoc />
    public partial class orderRelationAndTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeliverd = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.OrderId, x.FoodItemId });
                    table.ForeignKey(
                        name: "FK_OrderItems_FoodItems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "FoodItems",
                        principalColumn: "FoodItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89b2e4f3-832e-4054-8619-eb0c99a219a8", "AQAAAAIAAYagAAAAEE9fK97ZwIAuu2Et0bEtB/vMcrJLnHYSpDSgDrt2Xz7e3lzRaqttLX65v4eJYpsPyw==", "dd963ef8-421a-45be-84e1-c78af9d1e196" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FoodItemId",
                table: "OrderItems",
                column: "FoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f9a327d-83de-4322-a878-81a828d5d754", "AQAAAAIAAYagAAAAEKmCwx3HuS2GglObQStnnx3ZRaaXiSU+Bcws5GU3rh3L/aRY4STi1QMME/8JDfTl0Q==", "d07b6ad1-bbdb-47d6-b236-8d3a80392870" });
        }
    }
}
