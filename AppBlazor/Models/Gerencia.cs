using System.ComponentModel.DataAnnotations;

namespace AppBlazor
{
    public class Gerencia
    {
        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? Departamento { get; set; }
    }
}
