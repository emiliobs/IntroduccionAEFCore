using System.ComponentModel.DataAnnotations;

namespace IntroduccionAEFCore.DTOs
{
    public class GEneroCreacionDTO
    {
        [StringLength(maximumLength: 150)]
        public string Nombre { get; set; } = null!;
    }
}
