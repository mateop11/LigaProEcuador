using System.ComponentModel.DataAnnotations;

namespace LigaProEcuador.Models
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }
        public string NombreEquipo {  get; set; }

        public string CiudadEquipo {  get; set; }
        public int Titulos {  get; set; }
        public string AceptaExtranjeros {  get; set; }
        public string Estadio {  get; set; }

    }
}
