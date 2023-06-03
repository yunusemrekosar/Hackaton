using Hackaton.Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    public class AdminController : Controller
    {
        readonly UserManager<UserApp> _userManager;
        readonly SignInManager<UserApp> _signInManager;

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
               
                var result = await _userManager.CreateAsync(tutor, "");

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(tutor, isPersistent: false);
                    return RedirectToAction("index", "home");
                }

                return NoContent();

            }
            return Content("burada 404 sayfasına yolla");
            return View();
        }

        public IActionResult TutorList()
        {
            return View();
        }

        public IActionResult StudentList()
        {
            return View();
        }

        public IActionResult AuditionList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangeUserStatus(int UserId)
        {
            return View();
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
