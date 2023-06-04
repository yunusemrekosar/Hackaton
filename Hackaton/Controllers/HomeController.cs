using Hackaton.Bussines.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserAppService _userAppService;

        public HomeController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            
            return View(_userAppService.GetTutors());
        }
    }
}
