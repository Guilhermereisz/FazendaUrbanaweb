using FazendaUrbanaweb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FazendaUrbanaweb.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Pedidoregistrado()
        {
            return View();
        }

        public IActionResult Paginainicial()
        {
            return View();
        }


        public IActionResult Index()
        {
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
