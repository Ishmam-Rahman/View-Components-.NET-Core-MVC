using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace View_Component.Controllers
{
    public class Fibbonacci : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexComponent()
        {
            return ViewComponent("Fibonacci", new { _range = 4 });
        }
    }
}
