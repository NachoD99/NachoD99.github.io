using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class MapNewAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Maps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Locality",
                table: "Maps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Maps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Maps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Maps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Maps",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "Locality",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Maps");
        }
    }
}
