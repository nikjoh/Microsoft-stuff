using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JqueryProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JqueryProject.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View(DataManager.GetCustomers());
        }

        // GET: /<controller>/
        public IActionResult GetPartialView(int id)
        {

            return PartialView("_ListCustomer", DataManager.GetCustomer(id));
        }

        // GET: /<controller>/
        public IActionResult GetCustomers()
        {

            return Json(DataManager.GetCustomers());
        }
    }
}
