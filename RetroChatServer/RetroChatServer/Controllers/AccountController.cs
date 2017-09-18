using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetroChatServer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using RetroChatServer.Models.Entities;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using RetroChatServer.Utils;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetroChatServer.Controllers
{
    public class AccountController : Controller
    {

        RetroChatContext context;

        public AccountController(RetroChatContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            return RedirectToAction(nameof(MembersController.Index), "Members");

        }


        [HttpPost]
        public IActionResult Logout()
        {
            // handle logout
            return Ok();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            context.Register(model);
            return RedirectToAction(nameof(MembersController.Index), "Members");

        }





    }
}
