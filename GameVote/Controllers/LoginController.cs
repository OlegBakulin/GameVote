using GameVote.Domain.DBServices;
using GameVote.Domain.Entities;
using GameVote.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameVote.Controllers
{
    public class LoginController : Controller
    {
        private readonly User _userManager;
        private readonly DBAUTH _signInManager;

        public LoginController(User userManager, DBAUTH signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
                [HttpGet]
                public IActionResult Login()
                {
                    return View();
                }

                [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) { return View(model); }

            _userManager.Email = model.UserName;
            _userManager.PasswordHash = model.Password;
            var loginResult = _signInManager.UserLog(_userManager);
                if (loginResult == null)
                    {
                        ModelState.AddModelError("", "Вход невозможен");
                        return View(model);
                    }

                    if (Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }

                    return RedirectToAction("Index", "Base");
                }


                [HttpGet]
                public IActionResult Register()
                {
                    return View();
                }


                [HttpPost, ValidateAntiForgeryToken]
                public IActionResult Register(RegisterUserViewModel model)
                {
                    if (!ModelState.IsValid) { return View(model); }

                    var user = new User { 
                        UserName = model.UserName,
                        Login = model.Login,
                        Email = model.Email,
                        PhoneNumber = model.PhoneNumber,
                        PasswordHash = model.Password
                    };

                    var createResult = _signInManager.UserReg(user);

                    if (createResult == null)
                    {
                        ModelState.AddModelError("", "Данный пользователь уже зарегестрирован.");
                        return View(model);
                    }

                    return RedirectToAction("Index", "Base");
                }


                [HttpPost, ValidateAntiForgeryToken]
                [Route("logout")]
                public IActionResult Logout(User user)
                {
                    _signInManager.UserOut(user);
                    return RedirectToAction("Index", "Base");
                }
                
    }
}