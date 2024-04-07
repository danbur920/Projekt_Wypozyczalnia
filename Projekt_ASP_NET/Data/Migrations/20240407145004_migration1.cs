using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_ASP_NET.Data.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_AspNetUsers_UserId1",
                table: "Branches");

            migrationBuilder.DropIndex(
                name: "IX_Branches_UserId1",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Branches");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Branches",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branches_UserId",
                table: "Branches",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_AspNetUsers_UserId",
                table: "Branches",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_AspNetUsers_UserId",
                table: "Branches");

            migrationBuilder.DropIndex(
                name: "IX_Branches_UserId",
                table: "Branches");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Branches",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Branches",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branches_UserId1",
                table: "Branches",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_AspNetUsers_UserId1",
                table: "Branches",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
