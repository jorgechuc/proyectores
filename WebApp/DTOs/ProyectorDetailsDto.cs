using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.DTOs
{
    public class ProyectorDetailsDto
    {
        public int Id { get; set; }
        
        public string Marca { get; set; } = string.Empty;
        
        public string Modelo { get; set; } = string.Empty;

        public string NumeroDeSerie { get; set; } = string.Empty;

        public SituacionProyector Situacion { get; set; }
            = SituacionProyector.Bueno;
        
        public DateTime FechaDeAlta { get; set; } = DateTime.Now;
        
        public DateTime? FechaDeBaja { get; set; } = null;

        public Departamento Departamento { get; set; }
    }
}
