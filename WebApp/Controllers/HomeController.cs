using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IProyectoresService _service;

        public HomeController(IProyectoresService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var modelo = _service.GetAll();
            return View(modelo);
        }

        public IActionResult Create()
        {
            var modelo = new HomeCreateViewModel();
            modelo.FechaDeAlta = DateTime.Now;
            return View(modelo);
        }

        [HttpPost]
        public IActionResult Create(Proyector proyector)
        {
            if (!ModelState.IsValid)
            {
                return View(proyector);
            }
            else
            {
                _service.AddProyector(proyector);
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Details(int id)
        {
            var modelo = _service.GetProyectorById(id);
            if (modelo != null)
            {
                return View(modelo);
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var modelo = _service.GetProyectorById(id);
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
                _service.Update(proyector);
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Delete(int id)
        {
            var modelo = _service.GetProyectorById(id);
            if (modelo != null)
            {
                return View(modelo);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var proyector = _service.GetProyectorById(id);
            if (proyector != null)
            {
                _service.Delete(proyector);
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
