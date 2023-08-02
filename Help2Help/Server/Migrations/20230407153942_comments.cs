using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 7, 12, 39, 42, 166, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PublicationId",
                table: "Comments",
                column: "PublicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4455));
        }
    }
}
