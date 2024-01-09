using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Design_A_Bear.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialcreateitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23595ea2-83a1-486a-824e-69e7b5f89cd4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79e872d6-fcb6-409c-a64a-816d0a0058c7");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgBase64 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b645205-951a-48a1-bd02-7ecd947671bb", "7063a339-27ee-4225-b7e2-28743f091681", "User", "USER" },
                    { "8fedb4ed-231f-4c18-bc9c-994c354bb319", "4c25e3d6-d87f-4d35-9a7c-741c655de49c", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b645205-951a-48a1-bd02-7ecd947671bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fedb4ed-231f-4c18-bc9c-994c354bb319");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23595ea2-83a1-486a-824e-69e7b5f89cd4", "03c94b4e-1a95-4b8a-be02-1fe894db3c61", "User", "USER" },
                    { "79e872d6-fcb6-409c-a64a-816d0a0058c7", "2bc90438-fe5c-431f-ae69-0f1d75612bcd", "Admin", "ADMIN" }
                });
        }
    }
}
