using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_app.Models;

namespace web_app.Controllers
{
    public class HomeController : Controller
    {
        List<Pizza> pizzaList;

        private readonly ILogger<HomeController> _logger;

        public HomeController()
        {
            pizzaList = new List<Pizza>();
            pizzaList.Add(new Pizza(1, "Hawajska", 19.99, "Najlepsza pizza na świecie z ananasem", "hawajska.png"));
            pizzaList.Add(new Pizza(2, "Pepperoni", 18.99, "Ostra pizzka z salami", "pepperoni.png"));
            pizzaList.Add(new Pizza(3, "Grecka", 21.10, "Super pizza prosto z grecji z serem feta i pomidorami", "grecka.png"));
            pizzaList.Add(new Pizza(4, "Capriciosa", 23.99, "Pyszna pizza z pieczarkami", "capriciosa.png"));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllPizzas()
        {
            return View(pizzaList);
        }

        public IActionResult PizzaDetails(int id)
        {
            var pizza = pizzaList.FirstOrDefault(x => x.Id == id);
            return View(pizza);
        }

        public IActionResult CreateOrder(int id)
        {
            var pizza = pizzaList.FirstOrDefault(x => x.Id == id);
            ViewBag.pizza = pizza;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrder([Bind("PizzaId,City,Adress,Phone,Email")] Order order)
        {
            if(ModelState.IsValid)
            {
                order.OrderDate = DateTime.Now;
                var pizza = pizzaList.FirstOrDefault(X => X.Id == order.PizzaId);
                ViewBag.orderPizza = pizza;
                return View("PlaceOrder", order);
            }
            else
            {
                var pizza = pizzaList.FirstOrDefault(X => X.Id == order.PizzaId);
                ViewBag.pizza = pizza;
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
