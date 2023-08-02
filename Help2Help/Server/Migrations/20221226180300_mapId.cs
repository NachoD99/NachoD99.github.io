using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class mapId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MapId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 26, 15, 2, 59, 864, DateTimeKind.Local).AddTicks(8465));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MapId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 23, 18, 48, 58, 228, DateTimeKind.Local).AddTicks(3154));
        }
    }
}
