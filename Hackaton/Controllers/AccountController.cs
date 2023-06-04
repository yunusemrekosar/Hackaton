using Hackaton.Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal.LoginModel;

namespace Hackaton.Controllers
{
    public class AccountController : Controller
    {
        readonly UserManager<UserApp> _userManager;
        readonly SignInManager<UserApp> _signInManager;

        public AccountController(SignInManager<UserApp> signInManager, UserManager<UserApp> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login(InputModel model)
        {
            if (!ModelState.IsValid) 
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null && await _userManager.CheckPasswordAsync(user,model.Password))  
                {
                    return RedirectToAction("index", "home");
                }
                    return NoContent();

            }
            return Content("burada 404 sayfasına yolla");
        }


        [HttpPost]
        public async Task<IActionResult> Register(Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal.RegisterModel.InputModel model)
        {
            if (!ModelState.IsValid)
            {
                var user = new UserApp()
                {
                    UserName = model.Email,
                    Email = model.Email,
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }

                return NoContent();

            }
            return Content("burada 404 sayfasına yolla");
        }
    }
}
