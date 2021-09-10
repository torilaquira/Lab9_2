using Microsoft.AspNetCore.Mvc;
using PracticeLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeLab.Controllers
{
    public class MDotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPage()
        {
            ViewData["FirstName"] = "Tori";
            ViewData["LastName"] = "Hudson";
            return View();
        }

        public IActionResult SignUpForm()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult ThankYou(Customer cust)
        {

            if (cust.FirstName == null)
            {
                ViewData["Message"] = "Please fill in all fields";
                return View("SignupForm");
            }
            else
            {
                return View(cust);
            }
        }
    }
}
