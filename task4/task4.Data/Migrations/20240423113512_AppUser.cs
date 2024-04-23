using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace task4.Data.Migrations
{
    /// <inheritdoc />
    public partial class AppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d40368e-6cc3-4939-bad9-adf8d905dc09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba3635a2-7c53-462d-8f64-bd7f2bed99dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c998c67e-a7d6-44ba-a70b-e3198f29df42");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "124521a1-7216-4ac2-a29f-aac2f881d256", null, "seller", "seller" },
                    { "1ede4b65-ffb8-43d5-bede-daa75769424a", null, "admin", "admin" },
                    { "b40ba17e-84fe-4ce7-b193-0c4d85dff115", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "124521a1-7216-4ac2-a29f-aac2f881d256");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ede4b65-ffb8-43d5-bede-daa75769424a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b40ba17e-84fe-4ce7-b193-0c4d85dff115");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d40368e-6cc3-4939-bad9-adf8d905dc09", null, "seller", "seller" },
                    { "ba3635a2-7c53-462d-8f64-bd7f2bed99dd", null, "admin", "admin" },
                    { "c998c67e-a7d6-44ba-a70b-e3198f29df42", null, "client", "client" }
                });
        }
    }
}
