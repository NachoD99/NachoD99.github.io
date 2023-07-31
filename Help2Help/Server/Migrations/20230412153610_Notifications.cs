using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class Notifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

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
    }
}
