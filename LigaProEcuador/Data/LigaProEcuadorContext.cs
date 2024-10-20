using Microsoft.EntityFrameworkCore;
using LigaProEcuador.Models;

namespace LigaProEcuador.Data
{
    public class LigaProEcuadorContext : DbContext
    {
        public LigaProEcuadorContext(DbContextOptions<LigaProEcuadorContext> options)
            : base(options)
        {
        }

        public DbSet<Equipo> Equipo { get; set; } = default!;
        public DbSet<Estadio> Estadio { get; set; } = default!;
        public DbSet<Jugador> Jugador { get; set; } = default!;

        // Seeding de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding de Equipos
            modelBuilder.Entity<Equipo>().HasData(
                new Equipo { IdEquipo = 1, NombreEquipo = "Barcelona SC", CiudadEquipo = "Guayaquil", Titulos = 16, AceptaExtranjeros = "si", Estadio = "Estadio Banco Pichincha" },
                new Equipo { IdEquipo = 2, NombreEquipo = "CS Emelec", CiudadEquipo = "Guayaquil", Titulos = 14, AceptaExtranjeros = "si", Estadio = "Estadio George Capwell Banco del Austro" },
                new Equipo { IdEquipo = 3, NombreEquipo = "Sociedad Deportiva Aucas", CiudadEquipo = "Quito", Titulos = 1, AceptaExtranjeros = "si", Estadio = "Estadio Cooprogreso Gonzalo Pozo Ripalda" },
                new Equipo { IdEquipo = 4, NombreEquipo = "Liga Deportiva Universitaria", CiudadEquipo = "Quito", Titulos = 12, AceptaExtranjeros = "si", Estadio = "Estadio Rodrigo Paz Delgado" },
                new Equipo { IdEquipo = 5, NombreEquipo = "Club Deportivo El Nacional", CiudadEquipo = "Quito", Titulos = 13, AceptaExtranjeros = "si", Estadio = "Estadio Olímpico Atahualpa" },
                new Equipo { IdEquipo = 6, NombreEquipo = "Delfín Sporting Club", CiudadEquipo = "Manta", Titulos = 1, AceptaExtranjeros = "si", Estadio = "Estadio Jocay" },
                new Equipo { IdEquipo = 7, NombreEquipo = "Club Deportivo Cuenca", CiudadEquipo = "Cuenca", Titulos = 1, AceptaExtranjeros = "si", Estadio = "Banco del Austro Alejandro Serrano Aguilar" },
                new Equipo { IdEquipo = 8, NombreEquipo = "Club Universidad Católica", CiudadEquipo = "Quito", Titulos = 0, AceptaExtranjeros = "si", Estadio = "Estadio Olímpico Atahualpa" },
                new Equipo { IdEquipo = 9, NombreEquipo = "Club Deportivo Macará", CiudadEquipo = "Ambato", Titulos = 0, AceptaExtranjeros = "si", Estadio = "Estadio Universidad Indoamérica Bellavista" },
                new Equipo { IdEquipo = 10, NombreEquipo = "Club Independiente del Valle", CiudadEquipo = "Quito", Titulos = 6, AceptaExtranjeros = "si", Estadio = "Estadio Banco Guayaquil" },
                new Equipo { IdEquipo = 11, NombreEquipo = "Club Técnico Universitario", CiudadEquipo = "Ambato", Titulos = 0, AceptaExtranjeros = "si", Estadio = "Estadio Universidad Indoamérica Bellavista" },
                new Equipo { IdEquipo = 12, NombreEquipo = "Orense Sporting Club", CiudadEquipo = "Machala", Titulos = 0, AceptaExtranjeros = "si", Estadio = "Estadio 9 de mayo" },
                new Equipo { IdEquipo = 13, NombreEquipo = "Cumbayá Fútbol Club", CiudadEquipo = "Quito", Titulos = 0, AceptaExtranjeros = "si", Estadio = "Estadio Olímpico Atahualpa" },
                new Equipo { IdEquipo = 14, NombreEquipo = "Mushuc Runa", CiudadEquipo = "Ambato", Titulos = 0, AceptaExtranjeros = "si", Estadio = "Cooperativa de Ahorro y Crédito Mushuc Runa" },
                new Equipo { IdEquipo = 15, NombreEquipo = "Imbabura", CiudadEquipo = "Ibarra", Titulos = 0, AceptaExtranjeros = "si", Estadio = "Estadio Olímpico de Ibarra" },
                new Equipo { IdEquipo = 16, NombreEquipo = "Libertad Fútbol Club", CiudadEquipo = "Loja", Titulos = 0, AceptaExtranjeros = "si", Estadio = "Estadio Reina del Cisne" }
            );

            // Seeding de Estadios
            modelBuilder.Entity<Estadio>().HasData(
                new Estadio { IdEstadio = 1, Direccion = "Av. Barcelona", CiudadEstadio = "Guayaquil", Capacidad = 59283, IdEquipo = 1 },
                new Estadio { IdEstadio = 2, Direccion = "Gral. José A.Gómez", CiudadEstadio = "Guayaquil", Capacidad = 40000, IdEquipo = 2 },
                new Estadio { IdEstadio = 3, Direccion = "Av. Rumichaca Ñan", CiudadEstadio = "Quito", Capacidad = 18799, IdEquipo = 3 },
                new Estadio { IdEstadio = 4, Direccion = "Av. John F. Kennedy 817", CiudadEstadio = "Quito", Capacidad = 41575, IdEquipo = 4 },
                new Estadio { IdEstadio = 5, Direccion = "Av. Naciones Unidas", CiudadEstadio = "Quito", Capacidad = 38258, IdEquipo = 5 },
                new Estadio { IdEstadio = 6, Direccion = "27PW+FRW", CiudadEstadio = "Manta", Capacidad = 22000, IdEquipo = 6 },
                new Estadio { IdEstadio = 7, Direccion = "Av. del Estadio", CiudadEstadio = "Cuenca", Capacidad = 18549, IdEquipo = 7 },
                new Estadio { IdEstadio = 8, Direccion = "Av. Naciones Unidas", CiudadEstadio = "Quito", Capacidad = 38258, IdEquipo = 8 },
                new Estadio { IdEstadio = 9, Direccion = "Av Bolivariana", CiudadEstadio = "Ambato", Capacidad = 16467, IdEquipo = 9 },
                new Estadio { IdEstadio = 10, Direccion = "Complejo Independiente del Valle", CiudadEstadio = "Quito", Capacidad = 12000, IdEquipo = 10 },
                new Estadio { IdEstadio = 11, Direccion = "Av Bolivariana", CiudadEstadio = "Ambato", Capacidad = 16467, IdEquipo = 11 },
                new Estadio { IdEstadio = 12, Direccion = "Avenida de Las Palmeras 919", CiudadEstadio = "Machala", Capacidad = 16500, IdEquipo = 12 },
                new Estadio { IdEstadio = 13, Direccion = "Av. Naciones Unidas", CiudadEstadio = "Quito", Capacidad = 38258, IdEquipo = 13 },
                new Estadio { IdEstadio = 14, Direccion = "Via Ambato Guaranda, San Alfonso de Chibuleo", CiudadEstadio = "Ambato", Capacidad = 8200, IdEquipo = 14 },
                new Estadio { IdEstadio = 15, Direccion = "Av. Jaime Roldos Aguilera y, Sánchez y Cifuentes", CiudadEstadio = "Ibarra", Capacidad = 17300, IdEquipo = 15 },
                new Estadio { IdEstadio = 16, Direccion = "avenida Emiliano Ortega y calle Azuay", CiudadEstadio = "Loja", Capacidad = 14935, IdEquipo = 16 }
            );
        }
    }
}
