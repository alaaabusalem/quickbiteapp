using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiApp.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16f0320b-aa49-4263-821a-404d7617074b", "AQAAAAIAAYagAAAAED1+z5YKUDposNP3jYbIcyaZ1SMOhwv7LPbz7mAiYC4swsr3suzNRgn+VAaItBEQNg==", "8f01b45d-e1fc-4dd5-ab80-67faa5fc04b2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57113ea0-2d38-4dbe-891c-f523b651744d", "AQAAAAIAAYagAAAAECZjcsJUX/lqdNAX+frMGdezLqXyCc/ZYaq8T2VTesL4H+u46hgtqLBO2NNMWERucA==", "cb475450-ad3f-45cc-bd49-a740e61e21ca" });
        }
    }
}
