using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yolcu360.Data.Migrations
{
    public partial class changeFilledCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "PriceFor3Days",
                table: "Cars",
                newName: "PriceDaily");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PriceDaily",
                table: "Cars",
                newName: "PriceFor3Days");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Cars",
                type: "money",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
