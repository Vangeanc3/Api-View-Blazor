using System.ComponentModel.DataAnnotations;

namespace API_BLAZOR_
{
    public class ReadGerenteDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        public virtual Gerencia? Gerencia { get; set; }
    }
}
