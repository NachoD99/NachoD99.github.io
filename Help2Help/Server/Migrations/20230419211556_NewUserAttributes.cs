using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class NewUserAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AllowDonarEvents",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsUserFromDonar",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 18, 15, 56, 125, DateTimeKind.Local).AddTicks(8541));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowDonarEvents",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsUserFromDonar",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 12, 12, 36, 9, 833, DateTimeKind.Local).AddTicks(5637));
        }
    }
}
