using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class CommentNewAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserProfilePicture",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 15, 47, 8, 520, DateTimeKind.Local).AddTicks(8804));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserProfilePicture",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 11, 29, 50, 612, DateTimeKind.Local).AddTicks(5871));
        }
    }
}
