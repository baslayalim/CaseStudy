using CaseStudy.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CaseStudy.Web.Controllers
{
    public class HomeController : Controller
    {
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
        public IActionResult Index(string firstName, string lastName)
        {
            ViewBag.Name = string.Format("Name: {0} {1}", firstName, lastName);
            return View();
        }

    }
}
