﻿// <auto-generated />
using System;
using Help2Help.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Help2Help.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230109184431_DeleteUselessClases")]
    partial class DeleteUselessClases
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Help2Help.Shared.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Help2Help.Shared.EventCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FatherCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EventCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8133),
                            FatherCategory = "Ambiental",
                            Name = "Plásticos",
                            SubCategory = "Botellas de plástico"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8149),
                            FatherCategory = "Ambiental",
                            Name = "Plásticos",
                            SubCategory = "Tapitas"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8151),
                            FatherCategory = "Ambiental",
                            Name = "Plásticos",
                            SubCategory = "Envases"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8153),
                            FatherCategory = "Ambiental",
                            Name = "Plásticos",
                            SubCategory = "Bolsas de plástico"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8155),
                            FatherCategory = "Ambiental",
                            Name = "Plásticos",
                            SubCategory = "Otros plásticos"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8156),
                            FatherCategory = "Ambiental",
                            Name = "Papeles y cartones",
                            SubCategory = "Papeles (Diarios, revistas, impresiones)"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8158),
                            FatherCategory = "Ambiental",
                            Name = "Papeles y cartones",
                            SubCategory = "Cajas de Cartón"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8159),
                            FatherCategory = "Ambiental",
                            Name = "Papeles y cartones",
                            SubCategory = "Cartón de uso cotidiano (Cajas de alimentos, tubitos de papel)"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8161),
                            FatherCategory = "Ambiental",
                            Name = "Papeles y cartones",
                            SubCategory = "Envases tipo brick (lavados)"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8162),
                            FatherCategory = "Ambiental",
                            Name = "Papeles y cartones",
                            SubCategory = "Otros Papeles y Cartones"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8164),
                            FatherCategory = "Ambiental",
                            Name = "Vidrios",
                            SubCategory = "Botellas de Vidrio"
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8166),
                            FatherCategory = "Ambiental",
                            Name = "Vidrios",
                            SubCategory = "Tarros y frascos de conservas"
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8168),
                            FatherCategory = "Ambiental",
                            Name = "Vidrios",
                            SubCategory = "Jarras y copas de vidrio"
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8169),
                            FatherCategory = "Ambiental",
                            Name = "Vidrios",
                            SubCategory = "Otros Vidrios"
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8171),
                            FatherCategory = "Ambiental",
                            Name = "Metales",
                            SubCategory = "Aluminio (Latas)"
                        },
                        new
                        {
                            Id = 16,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8172),
                            FatherCategory = "Ambiental",
                            Name = "Metales",
                            SubCategory = "Cobre"
                        },
                        new
                        {
                            Id = 17,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8175),
                            FatherCategory = "Ambiental",
                            Name = "Metales",
                            SubCategory = "Hierro"
                        },
                        new
                        {
                            Id = 18,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8177),
                            FatherCategory = "Ambiental",
                            Name = "Metales",
                            SubCategory = "Otros Metales"
                        },
                        new
                        {
                            Id = 19,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8178),
                            FatherCategory = "Ambiental",
                            Name = "Desechos peligrosos",
                            SubCategory = "Pilas y baterías"
                        },
                        new
                        {
                            Id = 20,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8179),
                            FatherCategory = "Ambiental",
                            Name = "Desechos peligrosos",
                            SubCategory = "Aceites"
                        },
                        new
                        {
                            Id = 21,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8181),
                            FatherCategory = "Ambiental",
                            Name = "Desechos peligrosos",
                            SubCategory = "Residuos tecnológicos"
                        },
                        new
                        {
                            Id = 22,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8182),
                            FatherCategory = "Ambiental",
                            Name = "Desechos peligrosos",
                            SubCategory = "Residuos hospitalarios infecciosos"
                        },
                        new
                        {
                            Id = 23,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8184),
                            FatherCategory = "Ambiental",
                            Name = "Desechos peligrosos",
                            SubCategory = "Otros Desechos Peligrosos"
                        },
                        new
                        {
                            Id = 24,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8185),
                            FatherCategory = "Social",
                            Name = "Alimentos",
                            SubCategory = "Perecederos"
                        },
                        new
                        {
                            Id = 25,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8187),
                            FatherCategory = "Social",
                            Name = "Alimentos",
                            SubCategory = "No perecederos"
                        },
                        new
                        {
                            Id = 26,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8188),
                            FatherCategory = "Social",
                            Name = "Alimentos",
                            SubCategory = "Leche en polvo"
                        },
                        new
                        {
                            Id = 27,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8190),
                            FatherCategory = "Social",
                            Name = "Alimentos",
                            SubCategory = "Leche entera"
                        },
                        new
                        {
                            Id = 28,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8191),
                            FatherCategory = "Social",
                            Name = "Artículos de bebé",
                            SubCategory = ""
                        },
                        new
                        {
                            Id = 29,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8193),
                            FatherCategory = "Social",
                            Name = "Ropa",
                            SubCategory = "Niños"
                        },
                        new
                        {
                            Id = 30,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8195),
                            FatherCategory = "Social",
                            Name = "Ropa",
                            SubCategory = "Jóvenes"
                        },
                        new
                        {
                            Id = 31,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8196),
                            FatherCategory = "Social",
                            Name = "Ropa",
                            SubCategory = "Adultos"
                        },
                        new
                        {
                            Id = 32,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8197),
                            FatherCategory = "Social",
                            Name = "Hogar",
                            SubCategory = "Colchones y frazadas"
                        },
                        new
                        {
                            Id = 33,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8199),
                            FatherCategory = "Social",
                            Name = "Hogar",
                            SubCategory = "Higiene y limpieza"
                        },
                        new
                        {
                            Id = 34,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8200),
                            FatherCategory = "Social",
                            Name = "Hogar",
                            SubCategory = "Muebles"
                        },
                        new
                        {
                            Id = 35,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8201),
                            FatherCategory = "Social",
                            Name = "Hogar",
                            SubCategory = "Electrodomésticos"
                        },
                        new
                        {
                            Id = 36,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8203),
                            FatherCategory = "Social",
                            Name = "Hogar",
                            SubCategory = "Materiales para construcción"
                        },
                        new
                        {
                            Id = 37,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8205),
                            FatherCategory = "Social",
                            Name = "Hogar",
                            SubCategory = "Pintura"
                        },
                        new
                        {
                            Id = 38,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8206),
                            FatherCategory = "Social",
                            Name = "Hogar",
                            SubCategory = "Otros artículos para el hogar"
                        },
                        new
                        {
                            Id = 39,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8207),
                            FatherCategory = "Social",
                            Name = "Tecnología",
                            SubCategory = "Computadoras"
                        },
                        new
                        {
                            Id = 40,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8209),
                            FatherCategory = "Social",
                            Name = "Tecnología",
                            SubCategory = "Celulares"
                        },
                        new
                        {
                            Id = 41,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8210),
                            FatherCategory = "Social",
                            Name = "Tecnología",
                            SubCategory = "Otros artículos tecnológicos"
                        },
                        new
                        {
                            Id = 42,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8211),
                            FatherCategory = "Social",
                            Name = "Recreación",
                            SubCategory = "Juguetes"
                        },
                        new
                        {
                            Id = 43,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8214),
                            FatherCategory = "Social",
                            Name = "Recreación",
                            SubCategory = "Instrumentos musicales"
                        },
                        new
                        {
                            Id = 44,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8216),
                            FatherCategory = "Social",
                            Name = "Recreación",
                            SubCategory = "Artículos deportivos"
                        },
                        new
                        {
                            Id = 45,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8217),
                            FatherCategory = "Social",
                            Name = "Útiles escolares y libros",
                            SubCategory = ""
                        },
                        new
                        {
                            Id = 46,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8218),
                            FatherCategory = "Social",
                            Name = "Salud",
                            SubCategory = "Medicamentos"
                        },
                        new
                        {
                            Id = 47,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8220),
                            FatherCategory = "Social",
                            Name = "Salud",
                            SubCategory = "Ortopedia"
                        },
                        new
                        {
                            Id = 48,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8221),
                            FatherCategory = "Social",
                            Name = "Salud",
                            SubCategory = "Sangre"
                        },
                        new
                        {
                            Id = 49,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8223),
                            FatherCategory = "Social",
                            Name = "Mascotas",
                            SubCategory = "Adopción"
                        },
                        new
                        {
                            Id = 50,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8224),
                            FatherCategory = "Social",
                            Name = "Mascotas",
                            SubCategory = "Alimento balanceado"
                        },
                        new
                        {
                            Id = 51,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8226),
                            FatherCategory = "Social",
                            Name = "Mascotas",
                            SubCategory = "Otros artículos de mascotas"
                        },
                        new
                        {
                            Id = 52,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8228),
                            FatherCategory = "Social",
                            Name = "Otros",
                            SubCategory = ""
                        },
                        new
                        {
                            Id = 53,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8229),
                            FatherCategory = "Voluntariado",
                            Name = "Voluntariado",
                            SubCategory = ""
                        },
                        new
                        {
                            Id = 54,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8231),
                            FatherCategory = "Dinero",
                            Name = "Dinero",
                            SubCategory = ""
                        },
                        new
                        {
                            Id = 55,
                            CreatedDate = new DateTime(2023, 1, 9, 15, 44, 30, 618, DateTimeKind.Local).AddTicks(8232),
                            FatherCategory = "Ambiental",
                            Name = "Residuos orgánicos",
                            SubCategory = ""
                        });
                });

            modelBuilder.Entity("Help2Help.Shared.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnServer")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Help2Help.Shared.Map", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("CoordinateX")
                        .HasColumnType("decimal(18,15)");

                    b.Property<decimal>("CoordinateY")
                        .HasColumnType("decimal(18,15)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("Locality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("Help2Help.Shared.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("Help2Help.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AuthenticationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacebookLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAuthenticated")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MapId")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfilePictureId")
                        .HasColumnType("int");

                    b.Property<bool>("TermsAndConditionsAccepted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserPortraitId")
                        .HasColumnType("int");

                    b.Property<string>("WebPageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
