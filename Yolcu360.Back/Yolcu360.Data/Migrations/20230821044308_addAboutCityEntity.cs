using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yolcu360.Data.Migrations
{
    public partial class addAboutCityEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutCities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutCities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutCities_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutCities_CityId",
                table: "AboutCities",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutCities");
        }
    }
}
