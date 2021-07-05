using Microsoft.EntityFrameworkCore.Migrations;

namespace BookProject.Data.Migrations
{
    public partial class baseModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Categories_AuthorId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Products_CategoryId",
                table: "Authors");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Categories_CategoryId",
                table: "Authors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Products_AuthorId",
                table: "Authors",
                column: "AuthorId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Categories_CategoryId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Products_AuthorId",
                table: "Authors");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Categories_AuthorId",
                table: "Authors",
                column: "AuthorId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Products_CategoryId",
                table: "Authors",
                column: "CategoryId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
