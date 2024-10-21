using System.ComponentModel.DataAnnotations;

namespace LigaProEcuador.Models
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }

        [MaxLength(100)]
        public string NombreEquipo {  get; set; }
        [MaxLength(100)]

        


        public string CiudadEquipo {  get; set; }
        public int Titulos {  get; set; }
        public string AceptaExtranjeros {  get; set; }
        public string Estadio {  get; set; }

    }
}
