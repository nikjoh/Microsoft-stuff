using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetroChatServer.Utils;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetroChatServer.Controllers
{
    public class CordovaController : Controller
    {
        
        public ActionResult SetPlatformCookie(string platform)
        {
            if (!string.IsNullOrWhiteSpace(platform))
            {
                HttpContext.Response.Cookies.Append(Constants.platformCookieKey, platform);
                
            }
            return RedirectToAction(nameof(AccountController.Login), "Account");
        }
    }
}
