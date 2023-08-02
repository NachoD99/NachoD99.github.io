using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class UpdateDocuments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransactionID",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Documents");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 4, 12, 47, 28, 380, DateTimeKind.Local).AddTicks(2267));
        }
    }
}
