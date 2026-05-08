using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IProyectoresService _service;
        public HomeController()
        {
            _service = new ProyectoresEnMemoriaService();
        }

        public IActionResult Index()
        {
            var modelo = _service.GetAll();
            return View(modelo);
        }

        public IActionResult Create()
        {
            Proyector proyector = new Proyector();
            proyector.FechaDeAlta = DateTime.Now;
            return View(proyector);
        }

        [HttpPost]
        public IActionResult Create(Proyector proyector)
        {
            _service.AddProyector(proyector);
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
