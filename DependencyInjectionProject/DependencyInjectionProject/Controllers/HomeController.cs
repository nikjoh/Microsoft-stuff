using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjectionProject.Controllers
{
    public class HomeController : Controller
    {
        IContentService myService;

        public HomeController(IContentService myService)
        {
            this.myService = myService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IndexVM model = new IndexVM(myService.GetHeader(), myService.GetBody());
            return View(model);
        }

        public IActionResult Test()
        {
            throw new FormatException("Lol");
            return View();
        }
    }
}
