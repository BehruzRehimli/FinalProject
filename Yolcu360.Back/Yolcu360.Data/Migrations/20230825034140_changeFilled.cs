using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yolcu360.Data.Migrations
{
    public partial class changeFilled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MinDriverLisanseDay",
                table: "Cars",
                newName: "MinYoungDriverLisanseYear");

            migrationBuilder.AddColumn<int>(
                name: "MinDriverLisanseYear",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinDriverLisanseYear",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "MinYoungDriverLisanseYear",
                table: "Cars",
                newName: "MinDriverLisanseDay");
        }
    }
}
