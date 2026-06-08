using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProjetoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Boletim()
        {
            List<string> disciplinas = new List<string>()
            {
                "Matemática",
                "Português",
                "História",
                "Geografia",
                "Ciências"
            };

            List<double> notas = new List<double>()
            {
                9.5,
                8.0,
                6.0,
                4.5,
                7.0
            };

            ViewBag.Disciplinas = disciplinas;
            ViewBag.Notas = notas;

            return View();
        }
    }
}