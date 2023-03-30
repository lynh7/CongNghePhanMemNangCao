using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace rv.Controllers
{
    public class TinRaoVatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}