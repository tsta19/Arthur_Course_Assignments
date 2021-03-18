using Microsoft.EntityFrameworkCore.Migrations;

namespace CarCRUD.Migrations
{
    public partial class Addingthetestthingy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "CarParts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "CarParts");
        }
    }
}
