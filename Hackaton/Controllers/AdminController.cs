using Hackaton.Bussines.Abstract;
using Hackaton.Core;
using Hackaton.DAL.Abstract;
using Hackaton.Data.Entity;
using Hackaton.Models.UserApp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    public class AdminController : Controller
    {
        readonly UserManager<UserApp> _userManager;
        readonly SignInManager<UserApp> _signInManager;
        readonly IUserAppService _userService;

        public AdminController(SignInManager<UserApp> signInManager, UserManager<UserApp> userManager = null)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddTutor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTutor(UserApp tutor)
        {
            if (!ModelState.IsValid)
            {
                tutor.UserStatusId = 9;

                var result = await _userManager.CreateAsync(tutor, CodeGenerator.RandomPassword(10)); //todo burada patlayabilirsin

                if (result.Succeeded)
                {
                   await _userManager.AddToRoleAsync(tutor, "Tutor");
                }

                return NoContent();

            }
            return Content("burada 404 sayfasına yolla");
        }

        public IActionResult TutorList()
        {
           
            return View(_userService.GetTutors());
        }

        public IActionResult StudentList()
        {
            return View(_userService.GetStudents());
        }

        public IActionResult AuditionList()
        {
            return View(_userService.GetAuditionList());
        }

        [HttpPost]
        public IActionResult ChangeUserStatus(int UserId, int statusId)
        {
            return View(_userService.ChangeUserStatus(UserId, statusId));
        }

        public IActionResult AddEditor()
        {
            return View();
        }
        public IActionResult AddEditor(UserApp editör)
        {
            return View();
        }

    }
}
