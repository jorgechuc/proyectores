using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Uso de ViewBag
            ViewBag.Id = 2;
            ViewBag.Marca = "Epson";
            ViewBag.Modelo = "XLight";
            ViewBag.NumeroDeSerie = "123456";
            ViewBag.Situacion = 1;
            ViewBag.FechaDeAlta = DateTime.Now.ToString("d");
            return View();
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
