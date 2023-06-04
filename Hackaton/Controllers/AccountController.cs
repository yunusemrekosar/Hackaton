﻿using Hackaton.Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Text.Encodings.Web;
using System.Text;
using Hackaton.Core;

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
        public async Task<IActionResult> Login(Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal.LoginModel.InputModel model)
        {
            if (ModelState.IsValid) 
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null && await _userManager.CheckPasswordAsync(user,model.Password))  
                {
                    return RedirectToAction("index", "home");
                }
                return Content("burada 404 sayfasına yolla");
            }
            return Content("burada 404 sayfasına yolla");
        }
 

        [HttpPost]
        public async Task<IActionResult> Register(Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal.RegisterModel.InputModel model)
        {
            if (ModelState.IsValid)
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

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = _userManager.GetUserId(User), code = code},
                        protocol: Request.Scheme);
                  
                    MailKitService.SendMailPassword(user.Email,HtmlEncoder.Default.Encode(callbackUrl));

                    return RedirectToAction("index", "home");
                }
                return NoContent();
            }
            return Content("burada 404 sayfasına yolla");
        }

        public async Task<IActionResult> ResetPassword(string Email)
        {
            if (ModelState.IsValid)
            { //todo: smtp
                var user = await _userManager.FindByEmailAsync(Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    return RedirectToPage("Identity/Account/ForgotPasswordConfirmation");
                }
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Page(
                    "/Account/ResetPassword",
                    pageHandler: null,
                    values: new { area = "Identity", code },
                    protocol: Request.Scheme);
                MailKitService.SendMailPassword(Email, HtmlEncoder.Default.Encode(callbackUrl));

                return RedirectToPage("Identity/Account/ForgotPasswordConfirmation");
            }
            return NoContent();
        }
        [HttpGet]
        public IActionResult NewPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewPassword(string email)
        {
            return View();
        }

    }
}
