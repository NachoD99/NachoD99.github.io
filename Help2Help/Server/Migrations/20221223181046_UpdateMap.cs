using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class UpdateMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StreetNumber",
                table: "Maps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 15, 10, 45, 743, DateTimeKind.Local).AddTicks(1045));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetNumber",
                table: "Maps");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 12, 52, 409, DateTimeKind.Local).AddTicks(125));
        }
    }
}
