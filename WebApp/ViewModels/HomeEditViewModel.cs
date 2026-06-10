using WebApp.DTOs;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class HomeEditViewModel
    {
        public ProyectorUpdateDto ProyectorUpdateDto { get; set; }
        public IEnumerable<Departamento> Departamentos { get; set; }
    }
}
