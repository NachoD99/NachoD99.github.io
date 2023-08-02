using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class DeleteUselessClases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Categories_CategoryId",
                table: "Publications");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "PublicationVariants");

            migrationBuilder.DropTable(
                name: "PublicationTypes");

            migrationBuilder.DropIndex(
                name: "IX_Publications_CategoryId",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Publications");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Publications",
                newName: "UserId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Publications",
                newName: "CategoryId");

            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Publications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Publications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicationVariants",
                columns: table => new
                {
                    PublicationId = table.Column<int>(type: "int", nullable: false),
                    PublicationTypeId = table.Column<int>(type: "int", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationVariants", x => new { x.PublicationId, x.PublicationTypeId });
                    table.ForeignKey(
                        name: "FK_PublicationVariants_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicationVariants_PublicationTypes_PublicationTypeId",
                        column: x => x.PublicationTypeId,
                        principalTable: "PublicationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Publications_CategoryId",
                table: "Publications",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationVariants_PublicationTypeId",
                table: "PublicationVariants",
                column: "PublicationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Categories_CategoryId",
                table: "Publications",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
