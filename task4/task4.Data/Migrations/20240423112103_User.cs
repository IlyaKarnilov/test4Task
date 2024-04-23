using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace task4.Data.Migrations
{
    /// <inheritdoc />
    public partial class User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5de23a7e-e79c-4ada-853e-812c18c18180");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75dd2ea8-b34b-4f0d-9a59-6df9193c458a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88701318-66bd-4709-a2ba-efd90b3a68aa");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "5de23a7e-e79c-4ada-853e-812c18c18180", null, "seller", "seller" },
                    { "75dd2ea8-b34b-4f0d-9a59-6df9193c458a", null, "admin", "admin" },
                    { "88701318-66bd-4709-a2ba-efd90b3a68aa", null, "client", "client" }
                });
        }
    }
}
