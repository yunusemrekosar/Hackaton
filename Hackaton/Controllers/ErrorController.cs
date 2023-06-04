using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
