using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class usernotguide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NotShowGuide",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 17, 30, 41, 799, DateTimeKind.Local).AddTicks(6966));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotShowGuide",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 6, 16, 13, 28, 89, DateTimeKind.Local).AddTicks(1685));
        }
    }
}
