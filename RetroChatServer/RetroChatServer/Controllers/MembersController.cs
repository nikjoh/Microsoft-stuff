using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RetroChatServer.Models.Entities;
using RetroChatServer.Models;
using Microsoft.AspNetCore.Cors;
using RetroChatServer.Utils;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetroChatServer.Controllers
{
    public class MembersController : Controller
    {
        RetroChatContext context;
        
        public MembersController(RetroChatContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var cookie = HttpContext.Request.Cookies[Constants.platformCookieKey];
            var platform = "dontknow";
            if (cookie != null)
            {
                platform = cookie;
            }
            ViewBag.Platform = platform;

            return View();
        }

        //[HttpGet]
        //public async Task<IActionResult> Home(AccountVM model)
        //{
        //    HomeVM home = await context.Home(model.Id);
        //    return Json(home);
        //}

        //[HttpGet]
        //public IActionResult Search()
        //{
        //    SearchVM[] users = context.GetAllUsers();
        //    return Json(users);
        //}

        //[HttpGet]
        //public IActionResult GetUser(int id)
        //{
        //    HomeVM user = context.GetUser(id);
        //    return Json(user);
        //}

        //[HttpPost]
        //public IActionResult AddPost(AddPostVM model)
        //{
        //    context.AddPost(model);
        //    return Ok();
        //}

        //[HttpGet]
        //public IActionResult Post(int id, int postId)
        //{
        //    PostVM post = context.GetUserPost(id, postId);
        //    return Json(post);
        //}
    }
}
