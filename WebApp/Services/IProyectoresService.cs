using WebApp.Models;

namespace WebApp.Services
{
    public interface IProyectoresService
    {
        IEnumerable<Proyector> GetAll();
        void AddProyector(Proyector proyector);

    }
}
