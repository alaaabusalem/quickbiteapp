using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodiApp.Migrations
{
	/// <inheritdoc />
	public partial class initialDbclass29 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "AspNetRoles",
				columns: table => new
				{
					Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
					Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetRoles", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "AspNetUsers",
				columns: table => new
				{
					Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
					UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
					EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
					PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
					SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
					PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
					PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
					TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
					LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
					LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
					AccessFailedCount = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetUsers", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "FoodCategories",
				columns: table => new
				{
					FoodCategoryId = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_FoodCategories", x => x.FoodCategoryId);
				});

			migrationBuilder.CreateTable(
				name: "AspNetRoleClaims",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
					table.ForeignKey(
						name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
						column: x => x.RoleId,
						principalTable: "AspNetRoles",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AspNetUserClaims",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
					table.ForeignKey(
						name: "FK_AspNetUserClaims_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AspNetUserLogins",
				columns: table => new
				{
					LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
					ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
					ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
					table.ForeignKey(
						name: "FK_AspNetUserLogins_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AspNetUserRoles",
				columns: table => new
				{
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
					table.ForeignKey(
						name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
						column: x => x.RoleId,
						principalTable: "AspNetRoles",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AspNetUserRoles_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AspNetUserTokens",
				columns: table => new
				{
					UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
					Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
					Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
					table.ForeignKey(
						name: "FK_AspNetUserTokens_AspNetUsers_UserId",
						column: x => x.UserId,
						principalTable: "AspNetUsers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "FoodItems",
				columns: table => new
				{
					FoodItemId = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FoodCategoryId = table.Column<int>(type: "int", nullable: false),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Price = table.Column<double>(type: "float", nullable: false),
					IsAvaliabe = table.Column<bool>(type: "bit", nullable: false),
					ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_FoodItems", x => x.FoodItemId);
					table.ForeignKey(
						name: "FK_FoodItems_FoodCategories_FoodCategoryId",
						column: x => x.FoodCategoryId,
						principalTable: "FoodCategories",
						principalColumn: "FoodCategoryId",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.InsertData(
				table: "AspNetRoles",
				columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
				values: new object[,]
				{
					{ "admin", "00000000-0000-0000-0000-000000000000", "Admin", "ADMIN" },
					{ "client", "00000000-0000-0000-0000-000000000000", "Client", "CLIENT" }
				});

			migrationBuilder.InsertData(
				table: "AspNetUsers",
				columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
				values: new object[] { "1", 0, "683207b3-5591-4f83-be06-e4ac129ffe66", "admin@example.com", true, false, null, "admin@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEN4A2FjkTgeGmT4StZl9SPO7d82LF/zDcabLA/FsqQ6bUqLGHj3l92XR0EIVOZkDMQ==", "1234567890", false, "7f61dd27-11ed-48ec-996d-63be8a7f5c37", false, "admin" });

			migrationBuilder.InsertData(
				table: "FoodCategories",
				columns: new[] { "FoodCategoryId", "Name" },
				values: new object[,]
				{
					{ 1, "Breakfast All Day" },
					{ 2, "Beverages and Drinks" },
					{ 3, "Seafood" },
					{ 4, "Pizza" },
					{ 5, "Pasta" },
					{ 6, "Desserts and Sweets" },
					{ 7, "Sides" },
					{ 8, "Soups" }
				});

			migrationBuilder.InsertData(
				table: "AspNetUserRoles",
				columns: new[] { "RoleId", "UserId" },
				values: new object[] { "admin", "1" });

			migrationBuilder.InsertData(
				table: "FoodItems",
				columns: new[] { "FoodItemId", "Description", "FoodCategoryId", "ImageUrl", "IsAvaliabe", "Name", "Price" },
				values: new object[,]
				{
					{ 1, "Fluffy scrambled eggs served with toast", 1, null, true, "Scrambled Eggs", 5.9900000000000002 },
					{ 2, "Stack of fluffy pancakes with syrup", 1, null, true, "Pancakes", 7.4900000000000002 },
					{ 3, "Scrambled eggs, bacon, and cheese wrapped in a tortilla", 1, null, true, "Classic Breakfast Burrito", 8.9900000000000002 },
					{ 4, "Chilled coffee served with ice", 2, null, true, "Iced Coffee", 3.9900000000000002 },
					{ 5, "Blended fresh fruit with yogurt or juice", 2, null, true, "Fruit Smoothie", 4.4900000000000002 },
					{ 6, "Rich and creamy hot chocolate", 2, null, true, "Hot Chocolate", 3.4900000000000002 },
					{ 7, "Juicy grilled shrimp with garlic butter", 3, null, true, "Grilled Shrimp", 12.99 },
					{ 8, "Creamy lobster soup with a hint of sherry", 3, null, true, "Lobster Bisque", 9.9900000000000002 },
					{ 9, "Assortment of seafood including shrimp, crab, and mussels", 3, null, true, "Seafood Platter", 22.989999999999998 },
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

			migrationBuilder.CreateIndex(
				name: "IX_AspNetRoleClaims_RoleId",
				table: "AspNetRoleClaims",
				column: "RoleId");

			migrationBuilder.CreateIndex(
				name: "RoleNameIndex",
				table: "AspNetRoles",
				column: "NormalizedName",
				unique: true,
				filter: "[NormalizedName] IS NOT NULL");

			migrationBuilder.CreateIndex(
				name: "IX_AspNetUserClaims_UserId",
				table: "AspNetUserClaims",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_AspNetUserLogins_UserId",
				table: "AspNetUserLogins",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_AspNetUserRoles_RoleId",
				table: "AspNetUserRoles",
				column: "RoleId");

			migrationBuilder.CreateIndex(
				name: "EmailIndex",
				table: "AspNetUsers",
				column: "NormalizedEmail");

			migrationBuilder.CreateIndex(
				name: "UserNameIndex",
				table: "AspNetUsers",
				column: "NormalizedUserName",
				unique: true,
				filter: "[NormalizedUserName] IS NOT NULL");

			migrationBuilder.CreateIndex(
				name: "IX_FoodItems_FoodCategoryId",
				table: "FoodItems",
				column: "FoodCategoryId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "AspNetRoleClaims");

			migrationBuilder.DropTable(
				name: "AspNetUserClaims");

			migrationBuilder.DropTable(
				name: "AspNetUserLogins");

			migrationBuilder.DropTable(
				name: "AspNetUserRoles");

			migrationBuilder.DropTable(
				name: "AspNetUserTokens");

			migrationBuilder.DropTable(
				name: "FoodItems");

			migrationBuilder.DropTable(
				name: "AspNetRoles");

			migrationBuilder.DropTable(
				name: "AspNetUsers");

			migrationBuilder.DropTable(
				name: "FoodCategories");
		}
	}
}
