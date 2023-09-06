using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yolcu360.Data.Migrations
{
    public partial class addRentDropOffice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DropOfficeId",
                table: "Rents",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DropOfficeId",
                table: "Rents");
        }
    }
}
