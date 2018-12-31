using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PropertyManager.Models;

namespace PropertyManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult BillPay()
        {
            ViewData["Message"] = "Pay Your Bills";

            return View();
        }

        public IActionResult Report()
        {
            ViewData["Message"] = "Report an issue to the Maintenance Team";

            return View();
        }

        public IActionResult Registration()
        {
            ViewData["Message"] = "Sign Up";

            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
