using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LigaProEcuador.Models;

namespace LigaProEcuador.Data
{
    public class LigaProEcuadorContext : DbContext
    {
        public LigaProEcuadorContext (DbContextOptions<LigaProEcuadorContext> options)
            : base(options)
        {
        }

        public DbSet<LigaProEcuador.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<LigaProEcuador.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<LigaProEcuador.Models.Jugador> Jugador { get; set; } = default!;
    }
}
