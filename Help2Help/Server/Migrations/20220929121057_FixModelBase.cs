using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Help2Help.Server.Migrations
{
    public partial class FixModelBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FatherCategory", "Name", "SubCategory", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4586), null, "Ambiental", "Plásticos", "Botellas de plástico", null },
                    { 2, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4607), null, "Ambiental", "Plásticos", "Tapitas", null },
                    { 3, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4609), null, "Ambiental", "Plásticos", "Envases", null },
                    { 4, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4611), null, "Ambiental", "Plásticos", "Bolsas de plástico", null },
                    { 5, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4613), null, "Ambiental", "Plásticos", "Otros plásticos", null },
                    { 6, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4615), null, "Ambiental", "Papeles y cartones", "Papeles (Diarios, revistas, impresiones)", null },
                    { 7, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4616), null, "Ambiental", "Papeles y cartones", "Cajas de Cartón", null },
                    { 8, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4618), null, "Ambiental", "Papeles y cartones", "Hueveras", null },
                    { 9, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4619), null, "Ambiental", "Papeles y cartones", "Envases tipo brick (lavados)", null },
                    { 10, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4621), null, "Ambiental", "Papeles y cartones", "Otros Papeles y Cartones", null },
                    { 11, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4623), null, "Ambiental", "Vidrios", "Botellas de Vidrio", null },
                    { 12, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4625), null, "Ambiental", "Vidrios", "Tarros y frascos de conservas", null },
                    { 13, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4626), null, "Ambiental", "Vidrios", "Jarras y copas de vidrio", null },
                    { 14, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4628), null, "Ambiental", "Vidrios", "Otros Vidrios", null },
                    { 15, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4629), null, "Ambiental", "Metales", "Aluminio (Latas)", null },
                    { 16, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4631), null, "Ambiental", "Metales", "Cobre", null },
                    { 17, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4632), null, "Ambiental", "Metales", "Hierro", null },
                    { 18, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4634), null, "Ambiental", "Metales", "Otros Metales", null },
                    { 19, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4635), null, "Ambiental", "Desechos peligrosos", "Pilas y baterías", null },
                    { 20, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4637), null, "Ambiental", "Desechos peligrosos", "Aceites", null },
                    { 21, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4639), null, "Ambiental", "Desechos peligrosos", "Residuos tecnológicos", null },
                    { 22, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4640), null, "Ambiental", "Desechos peligrosos", "Residuos hospitalarios infecciosos", null },
                    { 23, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4642), null, "Ambiental", "Desechos peligrosos", "Otros Desechos Peligrosos", null },
                    { 24, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4644), null, "Social", "Alimentos", "Perecederos", null },
                    { 25, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4645), null, "Social", "Alimentos", "No perecederos", null },
                    { 26, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4647), null, "Social", "Alimentos", "Leche en polvo", null },
                    { 27, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4648), null, "Social", "Alimentos", "Leche entera", null },
                    { 28, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4650), null, "Social", "Artículos de bebé", "", null },
                    { 29, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4652), null, "Social", "Ropa", "Niños", null },
                    { 30, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4654), null, "Social", "Ropa", "Jóvenes", null },
                    { 31, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4655), null, "Social", "Ropa", "Adultos", null },
                    { 32, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4657), null, "Social", "Hogar", "Colchones y frazadas", null },
                    { 33, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4658), null, "Social", "Hogar", "Higiene y limpieza", null },
                    { 34, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4660), null, "Social", "Hogar", "Muebles", null },
                    { 35, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4662), null, "Social", "Hogar", "Electrodomésticos", null },
                    { 36, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4663), null, "Social", "Hogar", "Materiales para construcción", null },
                    { 37, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4665), null, "Social", "Hogar", "Pintura", null },
                    { 38, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4666), null, "Social", "Hogar", "Otros artículos para el hogar", null },
                    { 39, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4668), null, "Social", "Tecnología", "Computadoras", null },
                    { 40, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4670), null, "Social", "Tecnología", "Celulares", null },
                    { 41, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4671), null, "Social", "Tecnología", "Otros artículos tecnológicos", null },
                    { 42, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4673), null, "Social", "Recreación", "Juguetes", null }
                });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FatherCategory", "Name", "SubCategory", "UpdatedDate" },
                values: new object[,]
                {
                    { 43, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4674), null, "Social", "Recreación", "Instrumentos musicales", null },
                    { 44, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4676), null, "Social", "Recreación", "Artículos deportivos", null },
                    { 45, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4678), null, "Social", "Útiles escolares y libros", "", null },
                    { 46, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4679), null, "Social", "Salud", "Medicamentos", null },
                    { 47, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4680), null, "Social", "Salud", "Ortopedia", null },
                    { 48, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4682), null, "Social", "Salud", "Sangre", null },
                    { 49, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4795), null, "Social", "Mascotas", "Adopción", null },
                    { 50, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4798), null, "Social", "Mascotas", "Alimento balanceado", null },
                    { 51, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4799), null, "Social", "Mascotas", "Otros artículos de mascotas", null },
                    { 52, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4801), null, "Social", "Otros", "", null },
                    { 53, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4802), null, "Voluntariado", "Voluntariado", "", null },
                    { 54, new DateTime(2022, 9, 29, 9, 10, 57, 153, DateTimeKind.Local).AddTicks(4803), null, "Dinero", "Dinero", "", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: 54);
        }
    }
}
