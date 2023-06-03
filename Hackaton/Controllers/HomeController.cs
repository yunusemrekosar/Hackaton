using Hackaton.DAL.Abstract;
using Hackaton.Data.Entity;
using Hackaton.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hackaton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly IUserAppDal _userAppDal;
        readonly UserManager<UserApp> _userManager;


        public HomeController(ILogger<HomeController> logger, UserManager<UserApp> userManager, IUserAppDal userAppDal)
        {
            _logger = logger;
            _userManager = userManager;
            _userAppDal = userAppDal;
        }

        public async Task<IActionResult> Index()
        {
            UserApp u = new();
            u.FullName = "";
            u.Email = "dadsndsa";
            u.UserName = "dadsndsa";
            u.EmailConfirmed = true;


            var result = await _userManager.CreateAsync(u,"sasA123!");

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