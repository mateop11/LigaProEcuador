using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LigaProEcuador.Migrations
{
    /// <inheritdoc />
    public partial class Migracion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipo",
                columns: table => new
                {
                    IdEquipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEquipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CiudadEquipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Titulos = table.Column<int>(type: "int", nullable: false),
                    AceptaExtranjeros = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estadio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo", x => x.IdEquipo);
                });

            migrationBuilder.CreateTable(
                name: "Estadio",
                columns: table => new
                {
                    IdEstadio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CiudadEstadio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false),
                    IdEquipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadio", x => x.IdEstadio);
                    table.ForeignKey(
                        name: "FK_Estadio_Equipo_IdEquipo",
                        column: x => x.IdEquipo,
                        principalTable: "Equipo",
                        principalColumn: "IdEquipo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jugador",
                columns: table => new
                {
                    IdJugador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Posicion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    IdEquipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugador", x => x.IdJugador);
                    table.ForeignKey(
                        name: "FK_Jugador_Equipo_IdEquipo",
                        column: x => x.IdEquipo,
                        principalTable: "Equipo",
                        principalColumn: "IdEquipo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Equipo",
                columns: new[] { "IdEquipo", "AceptaExtranjeros", "CiudadEquipo", "Estadio", "NombreEquipo", "Titulos" },
                values: new object[,]
                {
                    { 1, "si", "Guayaquil", "Estadio Banco Pichincha", "Barcelona SC", 16 },
                    { 2, "si", "Guayaquil", "Estadio George Capwell Banco del Austro", "CS Emelec", 14 },
                    { 3, "si", "Quito", "Estadio Cooprogreso Gonzalo Pozo Ripalda", "Sociedad Deportiva Aucas", 1 },
                    { 4, "si", "Quito", "Estadio Rodrigo Paz Delgado", "Liga Deportiva Universitaria", 12 },
                    { 5, "si", "Quito", "Estadio Olímpico Atahualpa", "Club Deportivo El Nacional", 13 },
                    { 6, "si", "Manta", "Estadio Jocay", "Delfín Sporting Club", 1 },
                    { 7, "si", "Cuenca", "Banco del Austro Alejandro Serrano Aguilar", "Club Deportivo Cuenca", 1 },
                    { 8, "si", "Quito", "Estadio Olímpico Atahualpa", "Club Universidad Católica", 0 },
                    { 9, "si", "Ambato", "Estadio Universidad Indoamérica Bellavista", "Club Deportivo Macará", 0 },
                    { 10, "si", "Quito", "Estadio Banco Guayaquil", "Club Independiente del Valle", 6 },
                    { 11, "si", "Ambato", "Estadio Universidad Indoamérica Bellavista", "Club Técnico Universitario", 0 },
                    { 12, "si", "Machala", "Estadio 9 de mayo", "Orense Sporting Club", 0 },
                    { 13, "si", "Quito", "Estadio Olímpico Atahualpa", "Cumbayá Fútbol Club", 0 },
                    { 14, "si", "Ambato", "Cooperativa de Ahorro y Crédito Mushuc Runa", "Mushuc Runa", 0 },
                    { 15, "si", "Ibarra", "Estadio Olímpico de Ibarra", "Imbabura", 0 },
                    { 16, "si", "Loja", "Estadio Reina del Cisne", "Libertad Fútbol Club", 0 }
                });

            migrationBuilder.InsertData(
                table: "Estadio",
                columns: new[] { "IdEstadio", "Capacidad", "CiudadEstadio", "Direccion", "IdEquipo" },
                values: new object[,]
                {
                    { 1, 59283, "Guayaquil", "Av. Barcelona", 1 },
                    { 2, 40000, "Guayaquil", "Gral. José A.Gómez", 2 },
                    { 3, 18799, "Quito", "Av. Rumichaca Ñan", 3 },
                    { 4, 41575, "Quito", "Av. John F. Kennedy 817", 4 },
                    { 5, 38258, "Quito", "Av. Naciones Unidas", 5 },
                    { 6, 22000, "Manta", "27PW+FRW", 6 },
                    { 7, 18549, "Cuenca", "Av. del Estadio", 7 },
                    { 8, 38258, "Quito", "Av. Naciones Unidas", 8 },
                    { 9, 16467, "Ambato", "Av Bolivariana", 9 },
                    { 10, 12000, "Quito", "Complejo Independiente del Valle", 10 },
                    { 11, 16467, "Ambato", "Av Bolivariana", 11 },
                    { 12, 16500, "Machala", "Avenida de Las Palmeras 919", 12 },
                    { 13, 38258, "Quito", "Av. Naciones Unidas", 13 },
                    { 14, 8200, "Ambato", "Via Ambato Guaranda, San Alfonso de Chibuleo", 14 },
                    { 15, 17300, "Ibarra", "Av. Jaime Roldos Aguilera y, Sánchez y Cifuentes", 15 },
                    { 16, 14935, "Loja", "avenida Emiliano Ortega y calle Azuay", 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estadio_IdEquipo",
                table: "Estadio",
                column: "IdEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Jugador_IdEquipo",
                table: "Jugador",
                column: "IdEquipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estadio");

            migrationBuilder.DropTable(
                name: "Jugador");

            migrationBuilder.DropTable(
                name: "Equipo");
        }
    }
}
