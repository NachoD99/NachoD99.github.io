using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class publicationImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Publications");

            migrationBuilder.AddColumn<int>(
                name: "PublicationId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 16, 18, 10, 272, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.CreateIndex(
                name: "IX_Images_PublicationId",
                table: "Images",
                column: "PublicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Publications_PublicationId",
                table: "Images",
                column: "PublicationId",
                principalTable: "Publications",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Publications_PublicationId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_PublicationId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "PublicationId",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Publications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8232));
        }
    }
}
