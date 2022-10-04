using System.ComponentModel.DataAnnotations;

namespace API_BLAZOR_
{
    public class CreateGerenteDto
    {
        [Required]
        public string? Nome { get; set; }
        [Required]
        public int GerenciaId { get; set; }
    }
}
