using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StatehandlingProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StatehandlingProject.Controllers
{
    public class SettingsController : Controller
    {
        IMemoryCache cache;
        const string Message = "_Message";
        const string Email = "_Email";
        const string Company = "_Company";

        public SettingsController(IMemoryCache cache)
        {
            this.cache = cache;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateSettingsVM model)
        {
            if (ModelState.IsValid)
            {
                TempData[Message] = "Dina värden har sparats!";
                HttpContext.Session.SetString(Company, model.CompanyName);
                cache.Set(Email, model.Email);

                return RedirectToAction(nameof(SettingsController.Display));
            }
            return View(model);
        }



        public IActionResult Display()
        {
            var model = new DisplaySettingsVM
            {
                Message = TempData[Message],
                Email = cache.Get(Email),
                CompanyName = HttpContext.Session.GetString(Company)
            };
            return View(model);
        }
    }
}
