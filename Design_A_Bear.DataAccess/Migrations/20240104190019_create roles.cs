using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Design_A_Bear.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class createroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23595ea2-83a1-486a-824e-69e7b5f89cd4", "03c94b4e-1a95-4b8a-be02-1fe894db3c61", "User", "USER" },
                    { "79e872d6-fcb6-409c-a64a-816d0a0058c7", "2bc90438-fe5c-431f-ae69-0f1d75612bcd", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23595ea2-83a1-486a-824e-69e7b5f89cd4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79e872d6-fcb6-409c-a64a-816d0a0058c7");
        }
    }
}
