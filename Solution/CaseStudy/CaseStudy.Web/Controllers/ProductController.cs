using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
