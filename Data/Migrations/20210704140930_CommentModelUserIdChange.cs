using Microsoft.EntityFrameworkCore.Migrations;

namespace BookProject.Data.Migrations
{
    public partial class CommentModelUserIdChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_BookUserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BookUserId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "BookUserId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookUserId1",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BookUserId1",
                table: "Comments",
                column: "BookUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_BookUserId1",
                table: "Comments",
                column: "BookUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_BookUserId1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BookUserId1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "BookUserId1",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "BookUserId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
