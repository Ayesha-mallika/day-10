using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace FirstWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Landing()
        {
            return View();
        }
        [ActionName ("Foxy")]
        public IActionResult CannotBeTheNameInTheResultCozItsReallyLong()
        {
            return View();
        }
    }
}
