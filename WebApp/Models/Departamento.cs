using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe proporcionar el título del departamento")]
        public string Titulo { get; set; } = string.Empty;
    }
}
