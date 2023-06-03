using Hackaton.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddTutor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTutor(UserApp tutor)
        {
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
