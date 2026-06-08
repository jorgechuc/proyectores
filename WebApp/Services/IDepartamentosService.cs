using WebApp.Models;

namespace WebApp.Services
{
    public interface IDepartamentosService
    {
        IEnumerable<Departamento> Get();
        //Departamento? GetDepartamentoById(int id);
        //void Add(Departamento departamento);
        //Departamento Update(Departamento departamento);
        //Departamento Delete(int id);
    }
}
