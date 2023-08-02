using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class Event : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EventCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 6, 9, 15, 29, 290, DateTimeKind.Local).AddTicks(6440));
        }
    }
}
