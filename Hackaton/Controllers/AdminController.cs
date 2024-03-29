﻿using Hackaton.Bussines.Abstract;
using Hackaton.Core;
using Hackaton.DAL.Abstract;
using Hackaton.Data;
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
		readonly ApplicationDbContext _context;

		public AdminController(SignInManager<UserApp> signInManager, UserManager<UserApp> userManager = null, IUserAppService userAppService = null)
		{
			_signInManager = signInManager;
			_userManager = userManager;
			_userAppService = userAppService;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _userAppService.GetUnknownList());
		}

        public IActionResult Audition()
        {
            return View(_userAppService.GetAuditionList());
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

		public async Task<IActionResult> TutorList()
		{

			return View(await _userAppService.GetTutors());
		}

		public async Task<IActionResult> StudentList()
		{
			return View(await _userAppService.GetStudents());
		}

		[HttpPost]
		public IActionResult ChangeUserStatus(int UserId, int statusId)
		{
			return View(_userAppService.ChangeUserStatus(UserId, statusId));
		}
		[HttpPost]
		public async Task<IActionResult> ChangeUserRole(int UserId, int RoleId)
		{
			if ( await _userAppService.ChangeUserRole(UserId, RoleId))
			{
				return RedirectToAction("Index", "admin");

			}
			return NoContent();
        }
    
	}
}
