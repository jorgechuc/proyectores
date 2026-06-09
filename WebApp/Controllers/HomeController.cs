using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.DTOs;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProyectoresService _proyectoresService;
        private readonly IDepartamentosService _departamentosService;

        public HomeController(IProyectoresService proyectoresService, 
            IDepartamentosService departamentosService)
        {
            _proyectoresService = proyectoresService;
            _departamentosService = departamentosService;
        }

        public IActionResult Index()
        {
            var modelo = _proyectoresService.GetAll();
            return View(modelo);
        }

        public IActionResult Create()
        {
            var modelo = new HomeCreateViewModel();
            modelo.ProyectorInsertDto = new ProyectorInsertDto();
            modelo.Departamentos = _departamentosService.Get();
            return View(modelo);
        }

        [HttpPost]
        public IActionResult Create(ProyectorInsertDto proyectorInsertDto)
        {
            if (!ModelState.IsValid)
            {
                var modelo = new HomeCreateViewModel();
                modelo.ProyectorInsertDto = proyectorInsertDto;
                modelo.Departamentos = _departamentosService.Get();
                return View(modelo);
            }
            else
            {
                var proyector = new Proyector()
                {
                    Marca = proyectorInsertDto.Marca,
                    Modelo = proyectorInsertDto.Modelo,
                    NumeroDeSerie = proyectorInsertDto.NumeroDeSerie,
                    FechaDeAlta = proyectorInsertDto.FechaDeAlta,
                    Situacion = proyectorInsertDto.Situacion,
                    DepartamentoId = proyectorInsertDto.DepartamentoId
                };
                _proyectoresService.AddProyector(proyector);
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Details(int id)
        {
            var modelo = _proyectoresService.GetProyectorById(id);
            if (modelo != null)
            {
                return View(modelo);
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var modelo = _proyectoresService.GetProyectorById(id);
            if (modelo != null)
            {
                return View(modelo);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Edit(Proyector proyector)
        {
            if (!ModelState.IsValid)
            {
                return View(proyector);
            }
            else
            {
                _proyectoresService.Update(proyector);
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Delete(int id)
        {
            var modelo = _proyectoresService.GetProyectorById(id);
            if (modelo != null)
            {
                return View(modelo);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var proyector = _proyectoresService.GetProyectorById(id);
            if (proyector != null)
            {
                _proyectoresService.Delete(proyector);
            }
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
