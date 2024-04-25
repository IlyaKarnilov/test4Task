using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test.Migrations
{
    /// <inheritdoc />
    public partial class FieldIsBlocked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73e0f7e6-497c-472a-be2e-3a2333de135c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8b45297-3af0-4acf-8765-cb2aa76305c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e52d89aa-59ee-4df6-939e-c078b9cd16e6");

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d43a578-0404-487e-8e57-a44e2db103f9", null, "seller", "seller" },
                    { "aacca6ad-1d34-4866-8aaa-68769631daeb", null, "client", "client" },
                    { "d7bb88c2-ba83-4a25-92bb-b90a1ccee5ad", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d43a578-0404-487e-8e57-a44e2db103f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aacca6ad-1d34-4866-8aaa-68769631daeb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7bb88c2-ba83-4a25-92bb-b90a1ccee5ad");

            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73e0f7e6-497c-472a-be2e-3a2333de135c", null, "client", "client" },
                    { "c8b45297-3af0-4acf-8765-cb2aa76305c2", null, "seller", "seller" },
                    { "e52d89aa-59ee-4df6-939e-c078b9cd16e6", null, "admin", "admin" }
                });
        }
    }
}
