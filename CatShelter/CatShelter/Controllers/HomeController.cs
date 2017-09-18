using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatShelter.Models;
using CatShelter.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CatShelter.Controllers
{
    public class HomeController : Controller
    {

        CatContext context;

        public HomeController(CatContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(context.getIndexVM());
        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            return View(context.GetCat(id));
        }


        [HttpGet]
        public IActionResult AddCat()
        {
            
            return View(new AddCatVM());
        }

        [HttpPost]
        public IActionResult AddCat(AddCatVM addCatVM)
        {
            if (ModelState.IsValid)
            {
                context.AddCat(addCatVM);
                return RedirectToAction(nameof(HomeController.Index));
            }
            return View(addCatVM);
        }

        [HttpGet]
        public IActionResult RemoveCat(int id)
        {
            context.RemoveCat(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
