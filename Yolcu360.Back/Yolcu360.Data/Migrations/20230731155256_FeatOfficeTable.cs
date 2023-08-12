using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yolcu360.Data.Migrations
{
    public partial class FeatOfficeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Offices",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OpenTimes",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Offices",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "OpenTimes",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Offices");
        }
    }
}
