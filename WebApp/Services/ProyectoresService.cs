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

        public Proyector? Delete(Proyector proyector)
        {
            if (proyector != null)
            {
                _contexto.Remove(proyector);
                _contexto.SaveChanges();
                return proyector;
            }
            return null;
        }

        public Proyector? GetProyectorById(int id)
        {
            return _contexto
                .Proyectores
                .FirstOrDefault<Proyector>(p => p.Id == id);
        }

        public IEnumerable<Proyector> GetAll()
        {
            return _contexto.Proyectores.ToList<Proyector>();
        }

        public void Update(Proyector proyector)
        {
            if (proyector != null)
            {
                _contexto.Proyectores.Update(proyector);
                _contexto.SaveChanges();
            }
        }
    }
}
