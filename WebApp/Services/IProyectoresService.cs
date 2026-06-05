using WebApp.Models;

namespace WebApp.Services
{
    public interface IProyectoresService
    {
        IEnumerable<Proyector> GetAll();
        void AddProyector(Proyector proyector);
        Proyector? GetProyectorById(int id);
        void Update(Proyector proyector);
        Proyector? Delete(Proyector proyector);

    }
}
