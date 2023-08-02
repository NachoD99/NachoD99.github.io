using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class TermAndConditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TermsAndConditionsAccepted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TermsAndConditionsAccepted",
                table: "Users");
        }
    }
}
