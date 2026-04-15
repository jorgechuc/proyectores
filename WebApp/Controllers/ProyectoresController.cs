using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProyectoresController : Controller
    {
        public IActionResult Index()
        {
            //return Content("<h1>Proyectores</h1>"
            //    + "<p>Aquí se mostrar&aacute; la lista de proyectores registrados.</p>",
            //    "text/html");
            return new ContentResult()
            {
                Content = "<h1>Proyectores</h1>"
                            + "<p>Aquí se mostrar&aacute; la lista de proyectores registrados.</p>",
                ContentType = "text/html"
            };
        }

        public IActionResult Details(int id)
        {
            return Content(
                $"<h1>Nuevo proyector</h1>"
                + $"<p>Aqu&iacute; se mostrar&aacute; la informaci&oacute;n del proyector {id}</p>",
                "text/html");
        }

        public IActionResult Delete(int id)
        {
            return Content(
                $"<h1>Dar de baja</h1>"
                + $"<p>Aqu&iacute; se dar&aacute; de baja el proyector {id}</p>",
                "text/html"
                );
        }
    }
}
