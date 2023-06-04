using Hackaton.Bussines.Abstract;
using Hackaton.Bussines.Concrete;
using Hackaton.Models.UserApp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Hackaton.Controllers
{
    //[Authorize(Roles = "Student , NewComer , Admin")]
    public class StudentController : Controller
    {
        private readonly IUserAppService _userAppService;

        public StudentController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _userAppService.GetTutors());
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
            _userAppService.UpdateUserAudition(getAudition);
            return View();
        }
    }
}
