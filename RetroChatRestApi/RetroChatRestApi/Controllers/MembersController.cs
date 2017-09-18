using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetroChatRestApi.Models.Members;
using RetroChatRestApi.Models.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetroChatRestApi.Controllers
{
    public class MembersController : Controller
    {
        RetroChatContext context;

        public MembersController(RetroChatContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Home(int id)
        {

            Home response = context.Home(id);
            return Json(response);
        }

        [HttpGet]
        public IActionResult GetUser(int id)
        {
            return Json(context.Home(id));
        }

        [HttpGet]
        public IActionResult Post(int id, int userId, int postId)
        {
            PostVM post = context.GetUserPost(id, userId, postId);
            return Json(post);
        }


        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Json(context.GetAllUsers());
        }

        [HttpPost]
        public IActionResult AddPost(AddPost model)
        {
            context.AddPost(model);
            return Ok();
        }

        [HttpPost]
        public bool LikePost(PostLike model)
        {
            return context.LikePost(model);
        }

        [HttpPost]
        public IActionResult CommentPost(PostComment model)
        {
            context.CommentPost(model);
            return Ok();
        }
    }
}
