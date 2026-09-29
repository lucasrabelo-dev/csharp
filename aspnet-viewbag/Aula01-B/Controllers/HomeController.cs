using System.Data;
using System.Diagnostics;
using Aula01_B.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula01_B.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //CRIANDO PROPRIEDADES DINAMICAS 
            ViewBag.UsuarioLogado = "Cidade";
            ViewBag.DataAcesso = DateTime.Now.ToLongDateString();
            ViewBag.NivelAcesso = "Administrador";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Nome = "Lucas";
            ViewBag.Endereco = DateTime.Now.ToLongDateString();
            ViewBag.Email = "Lucas.Rabelo@gmail.com";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
