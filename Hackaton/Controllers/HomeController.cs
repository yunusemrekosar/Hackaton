using Hackaton.Bussines.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserAppService _userAppService;
        readonly ITheClassService _a;
        readonly ApplicationDbContext _context;

        public HomeController(IUserAppService userAppService, ITheClassService a, ApplicationDbContext context)
        {
            _userAppService = userAppService;
            _a = a;
            _context = context;
        }
        public IActionResult sasa()
        {
            _context.Classes.Include(x => x.Users).Include(b => b.ClassDates).Include(w => w.Department).Where(a=>a.Id == 1).ToList();
            return Json(_a.GetAll());
        }
        public IActionResult Index()
        {
            TheClass contact =
        _context.Classes.Include("ClassDates.Department")
        .FirstOrDefault();
            return Json(contact);
        }

        public async Task<IActionResult> Privacy()
        {
            return View(await _userAppService.GetStudents());
        }
    }
}
