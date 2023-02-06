using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission04_sdcable.Models;

namespace Mission04_sdcable.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GradeForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeForm(FormModel model)
        {
            if (model.Assignments > 100 || model.Assignments < 0)
            {

            }

            return View();
        }
    }
}
