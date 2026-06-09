using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.DTOs
{
    public class ProyectorInsertDto
    {
        [Required(ErrorMessage = "Debe proporcionar un valor para el Marca")]
        [StringLength(24)]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Debe proporcionar un valor para el Modelo")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Debe proporcionar un valor para el Número de serie")]
        public string NumeroDeSerie { get; set; }

        public SituacionProyector Situacion { get; set; }
            = SituacionProyector.Bueno;

        [DataType(DataType.Date)]
        public DateTime FechaDeAlta { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime? FechaDeBaja { get; set; } = null;

        [Required]
        public int DepartamentoId { get; set; }
    }
}
