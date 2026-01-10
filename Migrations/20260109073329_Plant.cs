using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlantApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class Plant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Edible",
                table: "UserPlants");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserPlants");

            migrationBuilder.AddColumn<int>(
                name: "PlantId",
                table: "UserPlants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poisonous = table.Column<bool>(type: "bit", nullable: false),
                    Edible = table.Column<bool>(type: "bit", nullable: false),
                    HardyInWinter = table.Column<bool>(type: "bit", nullable: false),
                    LightRequirement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeafColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloomingPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HarvestMonths = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FertilizingCycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WateringCycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoilType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPlants_PlantId",
                table: "UserPlants",
                column: "PlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPlants_Plants_PlantId",
                table: "UserPlants",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPlants_Plants_PlantId",
                table: "UserPlants");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropIndex(
                name: "IX_UserPlants_PlantId",
                table: "UserPlants");

            migrationBuilder.DropColumn(
                name: "PlantId",
                table: "UserPlants");

            migrationBuilder.AddColumn<bool>(
                name: "Edible",
                table: "UserPlants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserPlants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
