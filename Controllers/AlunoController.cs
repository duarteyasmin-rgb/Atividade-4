using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Yasmin Duarte";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "3º Semestre";

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            ViewBag.Id = id;

            return Content($"Detalhes do aluno ID: {id}");
        }
    }
}