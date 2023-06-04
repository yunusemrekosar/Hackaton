using Hackaton.Bussines.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Hackaton.Controllers
{
    [Authorize(Roles = "Company , Admin")]
    public class CompanyController : Controller
    {
        private readonly IUserAppService _userAppService;

        public CompanyController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _userAppService.GetStudents());
        }
    }
}
