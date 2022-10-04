using System.ComponentModel.DataAnnotations;

namespace API_BLAZOR_
{
    public class CreateGerenciaDto
    {

        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? Departamento { get; set; }    
    }
}
