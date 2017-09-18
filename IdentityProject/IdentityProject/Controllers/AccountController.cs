using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IdentityProject.Models;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IdentityProject.Controllers
{

    public class AccountController : Controller
    {
        UserManager<IdentityUser> _userManager;
        SignInManager<IdentityUser> _signInManager;
        IdentityDbContext _context;


        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IdentityDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                
                return RedirectToAction(nameof(MembersController.Index), "Members");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(model.UserName,
                model.Password, model.RememberMe, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("UserName", "Invalid login attempt");
                return View(model);
            }
            return RedirectToAction(nameof(MembersController.Index), "Members");

        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // ensure database is created, else generate database
            await _context.Database.EnsureCreatedAsync();
            var result = await _userManager.CreateAsync(new IdentityUser(model.UserName), model.Password);

            if (!result.Succeeded)
            {
                // Add error on form
                ModelState.AddModelError("UserName", result.Errors.First().Description);
                return View(model);
            }

            // Login user (with non-persistent cookie (set true if you want persistent)
            await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
            // send user to login-protected action
            return RedirectToAction(nameof(MembersController.Index), "Members");

        }


    }
}
