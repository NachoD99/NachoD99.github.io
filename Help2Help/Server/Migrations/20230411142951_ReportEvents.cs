using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class ReportEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventReports", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5871));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventReports");

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
        }
    }
}
