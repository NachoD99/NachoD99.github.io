namespace Help2Help.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Composite Primary Key
            //modelBuilder.Entity<PublicationVariant>()
            //    .HasKey(p => new { p.PublicationId, p.PublicationTypeId });

            modelBuilder.Entity<EventCategory>().HasData(
                    new EventCategory
                    {
                        Id = 1,
                        Name = "Plásticos",
                        FatherCategory = "Ambiental",
                        SubCategory = "Botellas de plástico"
                    },
                    new EventCategory
                    {
                        Id = 2,
                        Name = "Plásticos",
                        FatherCategory = "Ambiental",
                        SubCategory = "Tapitas"
                    },
                    new EventCategory
                    {
                        Id = 3,
                        Name = "Plásticos",
                        FatherCategory = "Ambiental",
                        SubCategory = "Envases"
                    },
                    new EventCategory
                    {
                        Id = 4,
                        Name = "Plásticos",
                        FatherCategory = "Ambiental",
                        SubCategory = "Bolsas de plástico"
                    },
                    new EventCategory
                    {
                        Id = 5,
                        Name = "Plásticos",
                        FatherCategory = "Ambiental",
                        SubCategory = "Otros plásticos"
                    },
                    new EventCategory
                    {
                        Id = 6,
                        Name = "Papeles y cartones",
                        FatherCategory = "Ambiental",
                        SubCategory = "Papeles (Diarios, revistas, impresiones)"
                    },
                    new EventCategory
                    {
                        Id = 7,
                        Name = "Papeles y cartones",
                        FatherCategory = "Ambiental",
                        SubCategory = "Cajas de Cartón"
                    },
                    new EventCategory
                    {
                        Id = 8,
                        Name = "Papeles y cartones",
                        FatherCategory = "Ambiental",
                        SubCategory = "Cartón de uso cotidiano (Cajas de alimentos, tubitos de papel)"
                    },
                    new EventCategory
                    {
                        Id = 9,
                        Name = "Papeles y cartones",
                        FatherCategory = "Ambiental",
                        SubCategory = "Envases tipo brick (lavados)"
                    },
                    new EventCategory
                    {
                        Id = 10,
                        Name = "Papeles y cartones",
                        FatherCategory = "Ambiental",
                        SubCategory = "Otros Papeles y Cartones"
                    },
                    new EventCategory
                    {
                        Id = 11,
                        Name = "Vidrios",
                        FatherCategory = "Ambiental",
                        SubCategory = "Botellas de Vidrio"
                    },
                    new EventCategory
                    {
                        Id = 12,
                        Name = "Vidrios",
                        FatherCategory = "Ambiental",
                        SubCategory = "Tarros y frascos de conservas"
                    },
                    new EventCategory
                    {
                        Id = 13,
                        Name = "Vidrios",
                        FatherCategory = "Ambiental",
                        SubCategory = "Jarras y copas de vidrio"
                    },
                    new EventCategory
                    {
                        Id = 14,
                        Name = "Vidrios",
                        FatherCategory = "Ambiental",
                        SubCategory = "Otros Vidrios"
                    },
                    new EventCategory
                    {
                        Id = 15,
                        Name = "Metales",
                        FatherCategory = "Ambiental",
                        SubCategory = "Aluminio (Latas)"
                    },
                    new EventCategory
                    {
                        Id = 16,
                        Name = "Metales",
                        FatherCategory = "Ambiental",
                        SubCategory = "Cobre"
                    },
                    new EventCategory
                    {
                        Id = 17,
                        Name = "Metales",
                        FatherCategory = "Ambiental",
                        SubCategory = "Hierro"
                    },
                    new EventCategory
                    {
                        Id = 18,
                        Name = "Metales",
                        FatherCategory = "Ambiental",
                        SubCategory = "Otros Metales"
                    },
                    new EventCategory
                    {
                        Id = 19,
                        Name = "Desechos peligrosos",
                        FatherCategory = "Ambiental",
                        SubCategory = "Pilas y baterías"
                    },
                    new EventCategory
                    {
                        Id = 20,
                        Name = "Desechos peligrosos",
                        FatherCategory = "Ambiental",
                        SubCategory = "Aceites"
                    },
                    new EventCategory
                    {
                        Id = 21,
                        Name = "Desechos peligrosos",
                        FatherCategory = "Ambiental",
                        SubCategory = "Residuos tecnológicos"
                    },
                    new EventCategory
                    {
                        Id = 22,
                        Name = "Desechos peligrosos",
                        FatherCategory = "Ambiental",
                        SubCategory = "Residuos hospitalarios infecciosos"
                    },
                    new EventCategory
                    {
                        Id = 23,
                        Name = "Desechos peligrosos",
                        FatherCategory = "Ambiental",
                        SubCategory = "Otros Desechos Peligrosos"
                    },
                    new EventCategory
                    {
                        Id = 24,
                        Name = "Alimentos",
                        FatherCategory = "Social",
                        SubCategory = "Perecederos"
                    },
                    new EventCategory
                    {
                        Id = 25,
                        Name = "Alimentos",
                        FatherCategory = "Social",
                        SubCategory = "No perecederos"
                    },
                    new EventCategory
                    {
                        Id = 26,
                        Name = "Alimentos",
                        FatherCategory = "Social",
                        SubCategory = "Leche en polvo"
                    },
                    new EventCategory
                    {
                        Id = 27,
                        Name = "Alimentos",
                        FatherCategory = "Social",
                        SubCategory = "Leche entera"
                    },
                    new EventCategory
                    {
                        Id = 28,
                        Name = "Artículos de bebé",
                        FatherCategory = "Social"
                    },
                    new EventCategory
                    {
                        Id = 29,
                        Name = "Ropa",
                        FatherCategory = "Social",
                        SubCategory = "Niños"
                    },
                    new EventCategory
                    {
                        Id = 30,
                        Name = "Ropa",
                        FatherCategory = "Social",
                        SubCategory = "Jóvenes"
                    },
                    new EventCategory
                    {
                        Id = 31,
                        Name = "Ropa",
                        FatherCategory = "Social",
                        SubCategory = "Adultos"
                    },
                    new EventCategory
                    {
                        Id = 32,
                        Name = "Hogar",
                        FatherCategory = "Social",
                        SubCategory = "Colchones y frazadas"
                    },
                    new EventCategory
                    {
                        Id = 33,
                        Name = "Hogar",
                        FatherCategory = "Social",
                        SubCategory = "Higiene y limpieza"
                    },
                    new EventCategory
                    {
                        Id = 34,
                        Name = "Hogar",
                        FatherCategory = "Social",
                        SubCategory = "Muebles"
                    },
                    new EventCategory
                    {
                        Id = 35,
                        Name = "Hogar",
                        FatherCategory = "Social",
                        SubCategory = "Electrodomésticos"
                    },
                    new EventCategory
                    {
                        Id = 36,
                        Name = "Hogar",
                        FatherCategory = "Social",
                        SubCategory = "Materiales para construcción"
                    },
                    new EventCategory
                    {
                        Id = 37,
                        Name = "Hogar",
                        FatherCategory = "Social",
                        SubCategory = "Pintura"
                    },
                    new EventCategory
                    {
                        Id = 38,
                        Name = "Hogar",
                        FatherCategory = "Social",
                        SubCategory = "Otros artículos para el hogar"
                    },
                    new EventCategory
                    {
                        Id = 39,
                        Name = "Tecnología",
                        FatherCategory = "Social",
                        SubCategory = "Computadoras"
                    },
                    new EventCategory
                    {
                        Id = 40,
                        Name = "Tecnología",
                        FatherCategory = "Social",
                        SubCategory = "Celulares"
                    },
                    new EventCategory
                    {
                        Id = 41,
                        Name = "Tecnología",
                        FatherCategory = "Social",
                        SubCategory = "Otros artículos tecnológicos"
                    },
                    new EventCategory
                    {
                        Id = 42,
                        Name = "Recreación",
                        FatherCategory = "Social",
                        SubCategory = "Juguetes"
                    },
                    new EventCategory
                    {
                        Id = 43,
                        Name = "Recreación",
                        FatherCategory = "Social",
                        SubCategory = "Instrumentos musicales"
                    },
                    new EventCategory
                    {
                        Id = 44,
                        Name = "Recreación",
                        FatherCategory = "Social",
                        SubCategory = "Artículos deportivos"
                    },
                    new EventCategory
                    {
                        Id = 45,
                        Name = "Útiles escolares y libros",
                        FatherCategory = "Social"
                    },
                    new EventCategory
                    {
                        Id = 46,
                        Name = "Salud",
                        FatherCategory = "Social",
                        SubCategory = "Medicamentos"
                    },
                    new EventCategory
                    {
                        Id = 47,
                        Name = "Salud",
                        FatherCategory = "Social",
                        SubCategory = "Ortopedia"
                    },
                    new EventCategory
                    {
                        Id = 48,
                        Name = "Salud",
                        FatherCategory = "Social",
                        SubCategory = "Sangre"
                    },
                    new EventCategory
                    {
                        Id = 49,
                        Name = "Mascotas",
                        FatherCategory = "Social",
                        SubCategory = "Adopción"
                    },
                    new EventCategory
                    {
                        Id = 50,
                        Name = "Mascotas",
                        FatherCategory = "Social",
                        SubCategory = "Alimento balanceado"
                    },
                    new EventCategory
                    {
                        Id = 51,
                        Name = "Mascotas",
                        FatherCategory = "Social",
                        SubCategory = "Otros artículos de mascotas"
                    },
                    new EventCategory
                    {
                        Id = 52,
                        Name = "Otros",
                        FatherCategory = "Social"
                    },
                    new EventCategory
                    {
                        Id = 53,
                        Name = "Voluntariado",
                        FatherCategory = "Voluntariado"
                    },
                    new EventCategory
                    {
                        Id = 54,
                        Name = "Dinero",
                        FatherCategory = "Dinero"
                    },
                    new EventCategory
                    {
                        Id = 55,
                        Name = "Residuos orgánicos",
                        FatherCategory = "Ambiental"
                    },
                    new EventCategory
                    {
                        Id = 56,
                        Name = "Eventos de Donar App",
                        FatherCategory = "Eventos de Donar App"
                    }
                );
        }

        public DbSet<Publication> Publications { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<EventReport> EventReports { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}
