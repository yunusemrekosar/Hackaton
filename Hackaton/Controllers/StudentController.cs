using Hackaton.Bussines.Concrete;
using Hackaton.Models.UserApp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Hackaton.Controllers
{
    [Authorize(Roles = "Student , NewComer , Admin")]
    public class StudentController : Controller
    {
        private readonly UserAppManager _userAppManager;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult GetAudition()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetAudition(GetAuditionModel getAudition)
        {
            _userAppManager.UpdateUserAudition(getAudition);
            return View();
        }
    }
}
