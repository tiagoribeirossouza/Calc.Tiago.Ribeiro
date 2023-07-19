using Calc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Services;

namespace Calc.Controllers
{
    public class HomeController : Controller
    {
        ServiceBase _sb;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        [HttpPost]
        public IActionResult PostResultado(string numbers)
        {
            _sb = new ServiceBase();

            string resultado = _sb.PrincipaleOperation(numbers).ToString();

            return new ObjectResult(resultado);
        }

    }
}