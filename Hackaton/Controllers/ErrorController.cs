using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
