using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
