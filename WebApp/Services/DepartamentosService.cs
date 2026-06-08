using WebApp.Data;
using WebApp.Models;

namespace WebApp.Services
{
    public class DepartamentosService : IDepartamentosService
    {
        private readonly AppDbContext _contexto;

        public DepartamentosService(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Departamento> Get()
        {
            return _contexto.Departamentos.ToList<Departamento>();
        }
    }
}
