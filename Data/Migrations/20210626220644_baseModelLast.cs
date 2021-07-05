using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookProject.Data.Migrations
{
    public partial class baseModelLast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Categories_CategoryId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Products_AuthorId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_AuthorId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_CategoryId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Isbn",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Qty",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Sort",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "About",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Authors",
                newName: "About");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Isbn",
                table: "Products",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Products",
                type: "real",
                maxLength: 30,
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Qty",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sort",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Products",
                type: "nvarchar(175)",
                maxLength: 175,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_AuthorId",
                table: "Products",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Authors_AuthorId",
                table: "Products",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Authors_AuthorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AuthorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Isbn",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Qty",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Sort",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "About");

            migrationBuilder.RenameColumn(
                name: "About",
                table: "Authors",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Isbn",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Authors",
                type: "real",
                maxLength: 30,
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Qty",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sort",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Authors",
                type: "nvarchar(175)",
                maxLength: 175,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_AuthorId",
                table: "Authors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_CategoryId",
                table: "Authors",
                column: "CategoryId");

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
    }
}
