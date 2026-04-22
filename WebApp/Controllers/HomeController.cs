using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var modelo = LoadData();
            //var modelo = new List<Proyector>();
            return View(modelo);
        }

        private IEnumerable<Proyector> LoadData()
        {
            var proyectores = new List<Proyector>();

            proyectores.Add(new Proyector()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyector()
            {
                Id = 2,
                Marca = "BenQ",
                Modelo = "Plus",
                NumeroDeSerie = "56789",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyector()
            {
                Id = 3,
                Marca = "Epson",
                Modelo = "Performer",
                NumeroDeSerie = "456284",
                Situacion = SituacionProyector.Regular,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyector()
            {
                Id = 4,
                Marca = "Dell",
                Modelo = "Lighter",
                NumeroDeSerie = "A1B2C3",
                Situacion = SituacionProyector.Malo,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyector()
            {
                Id = 5,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "58763",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            return proyectores;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
