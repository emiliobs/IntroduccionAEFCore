using System.ComponentModel.DataAnnotations;

namespace IntroduccionAEFCore.DTOs
{
    public class ActorCreacionDTO
    {
        [StringLength(150)]
        public string Nombre { get; set; } = string.Empty;

        public decimal Fortuna { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
