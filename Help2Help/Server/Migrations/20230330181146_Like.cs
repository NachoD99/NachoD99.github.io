using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class Like : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LikesCount",
                table: "Publications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Liked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 15, 11, 46, 297, DateTimeKind.Local).AddTicks(4455));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropColumn(
                name: "LikesCount",
                table: "Publications");

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
        }
    }
}
