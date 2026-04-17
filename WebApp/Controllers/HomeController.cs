using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Uso de ViewData
            ViewData["Id"] = 1;
            ViewData["Marca"] = "Epson";
            ViewData["Modelo"] = "XLight";
            ViewData["NumeroDeSerie"] = "123456";
            ViewData["Situacion"] = 1;
            //ViewData["FechaDeAlta"] = DateTime.Now.ToString("d");
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
