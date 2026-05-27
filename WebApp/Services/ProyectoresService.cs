using WebApp.Data;
using WebApp.Models;

namespace WebApp.Services
{
    public class ProyectoresService : IProyectoresService
    {
        private readonly AppDbContext _contexto;

        public ProyectoresService(AppDbContext contexto)
        {
            this._contexto = contexto;
        }

        public void AddProyector(Proyector proyector)
        {
            if (proyector != null)
            {
                _contexto.Proyectores.Add(proyector);
                _contexto.SaveChanges();
            }

        }

        public IEnumerable<Proyector> GetAll()
        {
            return _contexto.Proyectores.ToList<Proyector>();
        }
    }
}
