using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiApp.Migrations
{
    /// <inheritdoc />
    public partial class newRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "client", "00000000-0000-0000-0000-000000000000", "Client", "CLIENT" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a365727-6158-4e29-8ce2-0493281fa0e1", "AQAAAAIAAYagAAAAEB0akDfAOm3c3/MuYp9M/Oa69fJV7s8dTZs2sjy2HDbjLmsHvSKhLqMZPA7UGzLYCA==", "fb5c5ec7-7eec-4c93-8f9b-0a3f1e26f25b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "client");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96892940-458b-482c-bf10-8826e958f6aa", "AQAAAAIAAYagAAAAEDHkzkPAuyHN6zYb+lbPwy3Rjei0WZX6Mn75kWs5JKGBRTW88fPBS5810xrNoKdNOA==", "eebb61eb-cf72-4214-9e64-a3ae3d3442ee" });
        }
    }
}
