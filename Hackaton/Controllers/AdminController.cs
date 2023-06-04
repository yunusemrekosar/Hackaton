using Hackaton.Bussines.Abstract;
using Hackaton.Core;
using Hackaton.DAL.Abstract;
using Hackaton.Data.Entity;
using Hackaton.Models.UserApp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        readonly UserManager<UserApp> _userManager;
        readonly SignInManager<UserApp> _signInManager;
        readonly IUserAppService _userAppService;

        public AdminController(SignInManager<UserApp> signInManager, UserManager<UserApp> userManager = null, IUserAppService userAppService = null)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userAppService = userAppService;
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
           
            return View(_userAppService.GetTutors());
        }

        public IActionResult StudentList()
        {
            return View(_userAppService.GetStudents());
        }

        public IActionResult AuditionList()
        {
            return View(_userAppService.GetAuditionList());
        }

        [HttpPost]
        public IActionResult ChangeUserStatus(int UserId, int statusId)
        {
            return View(_userAppService.ChangeUserStatus(UserId, statusId));
        }

        public IActionResult AddEditor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEditor(UserApp editor)
        {
            if (!ModelState.IsValid)
            {
                editor.UserStatusId = 9;

                var result = await _userManager.CreateAsync(editor, CodeGenerator.RandomPassword(10)); //todo burada patlayabilirsin

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(editor, "Editor");
                }

                return NoContent();

            }
            return Content("burada 404 sayfasına yolla");
        }

    }
}
