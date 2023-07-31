using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class EventModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Maps");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Maps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4803));
        }
    }
}
