using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using View_Component.Models;

namespace View_Component.Components
{
    public class Fibonacci : ViewComponent
    {
        public List<int> numbers = new List<int>();
        public Fibonacci()
        {
            numbers = FiboNumber.func();
        }

        public async Task<IViewComponentResult> InvokeAsync( int _range)
        {
            return View("Fibonacci", numbers.OrderByDescending(x=>x).Take(_range));
        }
    }
}
