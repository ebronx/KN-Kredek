using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KredekStronaZadDom.Models;

namespace KredekStronaZadDom.Controllers
{
    public class HomeController : Controller
    {
        List<kurs> courseList;

        private readonly ILogger<HomeController> _logger;

        public HomeController()
        {
            courseList = new List<kurs>();
            courseList.Add(new kurs(1, "kurs na prawo jazdy A", 2000, "Kurs uprawnia do jazdy motocyklami."));
            courseList.Add(new kurs(2, "kurs na prawo jazdy B", 2500, "Kurs uprawnia do jazdy samochodami osobowymi."));
            courseList.Add(new kurs(3, "kurs na prawo jazdy C", 4000, "Kurs uprawnia do jazdy pojazdami ciężarowymi."));
            courseList.Add(new kurs(4, "kurs na prawo jazdy D", 5000, "Kurs uprawnia do jazdy autobusami."));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllCourses()
        {
            return View(courseList);
        }

        public IActionResult courseDetails(int id)
        {
            var course = courseList.FirstOrDefault(x => x.Id == id);
            return View(course);
        }

        public IActionResult CreateOrder(int id)
        {
            var course = courseList.FirstOrDefault(x => x.Id == id);
            ViewBag.kurs = course;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrder([Bind("CourseId,City,Adress,Phone,Email")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderDate = DateTime.Now;
                var course = courseList.FirstOrDefault(X => X.Id == order.CourseId);
                ViewBag.orderedCourse = course;
                return View("PlaceOrder", order);
            }
            else
            {
                var course = courseList.FirstOrDefault(X => X.Id == order.CourseId);
                ViewBag.kurs = course;
                return View(order);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
