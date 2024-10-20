using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LigaProEcuador.Models
{
    public class Jugador
    {
        [Key]
        public int IdJugador {  get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Posicion {  get; set; }
        [Range(16,37)]
        public int Edad {  get; set; }

        public Equipo Equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo {  get; set; }


    }
}
