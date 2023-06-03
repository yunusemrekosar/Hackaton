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
        readonly ITheClassDal _classDal;
        readonly IDepartmentDal _departmentDal;


        public HomeController(ILogger<HomeController> logger, UserManager<UserApp> userManager, IUserAppDal userAppDal, ITheClassDal classDal, IDepartmentDal departmentDal)
        {
            _logger = logger;
            _userManager = userManager;
            _userAppDal = userAppDal;
            _classDal = classDal;
            _departmentDal = departmentDal;
        }

        public IActionResult Index()
        {
            return Content(_departmentDal.GetAll().Count.ToString()) ;
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