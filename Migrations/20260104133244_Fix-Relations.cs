using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlantApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class FixRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPlants_AspNetUsers_UserId1",
                table: "UserPlants");

            migrationBuilder.DropIndex(
                name: "IX_UserPlants_UserId1",
                table: "UserPlants");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserPlants");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserPlants",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlants_UserId",
                table: "UserPlants",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPlants_AspNetUsers_UserId",
                table: "UserPlants",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPlants_AspNetUsers_UserId",
                table: "UserPlants");

            migrationBuilder.DropIndex(
                name: "IX_UserPlants_UserId",
                table: "UserPlants");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserPlants",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "UserPlants",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserPlants_UserId1",
                table: "UserPlants",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPlants_AspNetUsers_UserId1",
                table: "UserPlants",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
