using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class Image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfilePictureId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserPortraitId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 22, 21, 0, 13, 27, DateTimeKind.Local).AddTicks(9023));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePictureId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserPortraitId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 13, 30, 15, 416, DateTimeKind.Local).AddTicks(6986));
        }
    }
}
