using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class FeaturedPublications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Publications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1,
                column: "Featured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 5,
                column: "Featured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 9,
                column: "Featured",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Publications");
        }
    }
}
