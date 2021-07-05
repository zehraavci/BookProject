using Microsoft.EntityFrameworkCore.Migrations;

namespace BookProject.Data.Migrations
{
    public partial class CommentModelUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BookUserId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BookUserId",
                table: "Comments",
                column: "BookUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_BookUserId",
                table: "Comments",
                column: "BookUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_BookUserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BookUserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "BookUserId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
