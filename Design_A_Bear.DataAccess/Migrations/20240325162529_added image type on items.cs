using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Design_A_Bear.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedimagetypeonitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bfced7a-6dcf-4b11-a3bc-bd72f048d277");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af41db86-84b4-4083-b8bb-f93672fe347d");

            migrationBuilder.AddColumn<string>(
                name: "ImageType",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "55e0697d-3c03-4d72-b482-35d117b4ebbb", "a998ab07-4e4e-41db-bb89-e758c0a99370", "Admin", "ADMIN" },
                    { "8dcfe372-8714-419a-8e50-147cec09308a", "dafba820-08b4-4df4-b7d9-97fffdf8fe9b", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55e0697d-3c03-4d72-b482-35d117b4ebbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dcfe372-8714-419a-8e50-147cec09308a");

            migrationBuilder.DropColumn(
                name: "ImageType",
                table: "Items");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2bfced7a-6dcf-4b11-a3bc-bd72f048d277", "01fbe2ef-0a46-47a0-a86e-99a9b4eae78e", "User", "USER" },
                    { "af41db86-84b4-4083-b8bb-f93672fe347d", "1f68a5a8-36c8-46c0-831b-663af6cd5988", "Admin", "ADMIN" }
                });
        }
    }
}
