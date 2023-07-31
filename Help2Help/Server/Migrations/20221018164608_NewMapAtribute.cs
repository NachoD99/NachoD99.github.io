using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class NewMapAtribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Maps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 18, 13, 46, 8, 183, DateTimeKind.Local).AddTicks(6537));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Maps");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 11, 22, 14, 7, 933, DateTimeKind.Local).AddTicks(3325));
        }
    }
}
