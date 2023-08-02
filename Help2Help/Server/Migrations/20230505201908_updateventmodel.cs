using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class updateventmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MercadoPagoLink",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 17, 19, 7, 171, DateTimeKind.Local).AddTicks(3610));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "MercadoPagoLink",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 16, 0, 48, 732, DateTimeKind.Local).AddTicks(4881));
        }
    }
}
