using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LigaProEcuador.Models
{
    public class Estadio
    {
        [Key]
        public int IdEstadio { get; set; }
        public string Direccion {  get; set; }
        public string CiudadEstadio { get; set; }
        public int Capacidad {  get; set; }
        public Equipo Equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
    }
}
