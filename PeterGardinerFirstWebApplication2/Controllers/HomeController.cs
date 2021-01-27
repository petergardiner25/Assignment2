using Microsoft.AspNetCore.Mvc;
using PeterGardinerFirstWebApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeterGardinerFirstWebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Calc")]
        public IActionResult Calc()
        {
            return View();
        }

        [HttpPost("Calc")]
        public IActionResult Calc(Class model)
        {
            return View();
        }
    }
}
