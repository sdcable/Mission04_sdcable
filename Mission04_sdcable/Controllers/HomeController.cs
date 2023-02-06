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
        //Returns to Index.cshtml
        public IActionResult Index()
        {
            return View();
        }

        //Returns GradeForm.cshtml if get
        [HttpGet]
        public IActionResult GradeForm()
        {
            return View();
        }

        //Returns GradeForm.cshtml if Post
        [HttpPost]
        public IActionResult GradeForm(FormModel model)
        {
            return View();
        }
    }
}
