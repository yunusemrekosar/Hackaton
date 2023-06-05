using Hackaton.Bussines.Abstract;
using Hackaton.Bussines.Concrete;
using Hackaton.DAL.Abstract;
using Hackaton.Models.UserApp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Hackaton.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
    readonly IDepartmentDal _departmentDal;
        private readonly IUserAppService _userAppService;

		public StudentController(IUserAppService userAppService, IDepartmentDal departmentDal)
		{
			_userAppService = userAppService;
			_departmentDal = departmentDal;
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

            return View(_departmentDal.GetAll());
        }

        [HttpPost]
        public IActionResult GetAudition(GetAuditionModel getAudition)
        {
            _userAppService.UpdateUserAudition(getAudition);
            return View();
        }
    }
}
