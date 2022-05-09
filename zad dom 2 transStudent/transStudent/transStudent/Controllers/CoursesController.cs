using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using transStudent.Models;

namespace transStudent.Controllers
{
    public class CoursesController : Controller
    {
        public ActionResult Random()
        {
            var Course = new Course() {Name="statystyka"};
            return View();
        }
    }
}
