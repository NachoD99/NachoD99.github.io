using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class UserAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacebookLink",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InstagramLink",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WebPageLink",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacebookLink",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InstagramLink",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WebPageLink",
                table: "Users");

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
    }
}
