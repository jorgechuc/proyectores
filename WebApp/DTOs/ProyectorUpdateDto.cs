using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.DTOs
{
    public class ProyectorUpdateDto
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Debe proporcionar un valor para el Marca")]
        [StringLength(24)]
        public string Marca { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Debe proporcionar un valor para el Modelo")]
        public string Modelo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe proporcionar un valor para el Número de serie")]
        public string NumeroDeSerie { get; set; } = string.Empty;

        public SituacionProyector Situacion { get; set; }
            = SituacionProyector.Bueno;
        
        public DateTime FechaDeAlta { get; set; } = DateTime.Now;
        
        public DateTime? FechaDeBaja { get; set; } = null;

        [Required]
        public int DepartamentoId { get; set; }

        //public Departamento Departamento { get; set; }
    }
}
