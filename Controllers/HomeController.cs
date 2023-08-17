using GameDb.Models; // Models Namespace
using Microsoft.AspNetCore.Mvc; // MVC Namespace
using System.Diagnostics; // Diagnostics Namespace

namespace GameDb.Controllers // Controllers Namespace
{
    public class HomeController : Controller // Home Controller
    {
        private readonly ILogger<HomeController> _logger; // Logger

        public HomeController(ILogger<HomeController> logger) // Constructor
        {
            _logger = logger;
        }

        public IActionResult Index() // Index Action
        {
            return View();
        }

        public IActionResult Privacy() // Privacy Action
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] // Cache Attribute
        public IActionResult Error() // Error Action
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
