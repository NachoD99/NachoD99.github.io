using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class PublicationSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, "This is the first publication", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Coat_types_3.jpg/800px-Coat_types_3.jpg", "Publicacion 1", 9.99m });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, "This is the second publication", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Collage_of_Six_Cats-02.jpg/250px-Collage_of_Six_Cats-02.jpg", "Publicacion 2", 19.99m });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, "This is the third publication", "https://upload.wikimedia.org/wikipedia/commons/d/dd/Scarlet_Macaw_and_Blue-and-gold_Macaw.jpg", "Publicacion 3", 29.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publications",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
