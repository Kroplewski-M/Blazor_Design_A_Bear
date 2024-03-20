using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Design_A_Bear.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initbasket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46fdba81-e8f1-45c9-9bfc-6132e669ef60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1653429-1ccd-42e8-a22c-821a2de37be3");

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c61b462-2869-4bc0-8ae5-b9cda73b6c99", "81d55358-1c7a-42a3-b479-221c67894b5d", "User", "USER" },
                    { "d74de67b-bc4a-4eb9-bbf3-3b551b5c9362", "e5d520d4-bfde-4f94-bd74-7752f679e2f1", "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ItemId",
                table: "BasketItems",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c61b462-2869-4bc0-8ae5-b9cda73b6c99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d74de67b-bc4a-4eb9-bbf3-3b551b5c9362");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46fdba81-e8f1-45c9-9bfc-6132e669ef60", "9d3a69ff-bfbc-4563-83d4-ae69602e7bbb", "Admin", "ADMIN" },
                    { "d1653429-1ccd-42e8-a22c-821a2de37be3", "e7e717ff-4d51-4179-b48b-f3f605235d0b", "User", "USER" }
                });
        }
    }
}
