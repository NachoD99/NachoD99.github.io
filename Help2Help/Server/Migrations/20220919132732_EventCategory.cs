using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class EventCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCategories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "FatherCategory", "Name", "SubCategory" },
                values: new object[,]
                {
                    { 1, "Ambiental", "Plástico", "Botellas" },
                    { 2, "Ambiental", "Plástico", "Tapitas" },
                    { 3, "Ambiental", "Plástico", "Envases" },
                    { 4, "Ambiental", "Plástico", "Otro" },
                    { 5, "Ambiental", "Cartón", "" },
                    { 6, "Ambiental", "Papel", "" },
                    { 7, "Ambiental", "RAEE", "" },
                    { 8, "Ambiental", "Pilas y Baterías", "" },
                    { 9, "Ambiental", "Vidrio", "" },
                    { 10, "Ambiental", "Metales", "" },
                    { 11, "Ambiental", "Otro", "" },
                    { 12, "Social", "Alimentos", "Perecederos" },
                    { 13, "Social", "Alimentos", "No perecederos" },
                    { 14, "Social", "Alimentos", "Leche en polvo" },
                    { 15, "Social", "Alimentos", "Leche entera" },
                    { 16, "Social", "Alimentos", "Otro" },
                    { 17, "Social", "Artículos de bebé", "" },
                    { 18, "Social", "Ropa", "Niños" },
                    { 19, "Social", "Ropa", "Jóvenes" },
                    { 20, "Social", "Ropa", "Adultos" },
                    { 21, "Social", "Hogar", "Colchones y frazadas" },
                    { 22, "Social", "Ropa", "Higiene y limpieza" },
                    { 23, "Social", "Ropa", "Muebles" },
                    { 24, "Social", "Ropa", "Electrodomésticos" },
                    { 25, "Social", "Tecnología", "" },
                    { 26, "Social", "Recreación", "Juguetes" },
                    { 27, "Social", "Recreación", "Instrumentos musicales" },
                    { 28, "Social", "Recreación", "Artículos deportivos" },
                    { 29, "Social", "Útiles escolares", "" },
                    { 30, "Social", "Salud", "Medicamentos" },
                    { 31, "Social", "Salud", "Ortopedia" },
                    { 32, "Social", "Salud", "Sangre" },
                    { 33, "Social", "Salud", "Otro" },
                    { 34, "Social", "Mascotas", "Adopción" },
                    { 35, "Social", "Mascotas", "Alimento balanceado" },
                    { 36, "Social", "Mascotas", "Otro" },
                    { 37, "Social", "Otro", "" },
                    { 38, "Social", "Voluntariado", "Voluntariado" },
                    { 39, "Social", "Dinero", "Dinero" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventCategories");
        }
    }
}
