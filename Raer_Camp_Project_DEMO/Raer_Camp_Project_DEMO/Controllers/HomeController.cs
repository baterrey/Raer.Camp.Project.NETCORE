using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Raer_Camp_Project_DEMO.Models;

namespace Raer_Camp_Project_DEMO.Controllers
{
    public class HomeController : Controller
    {
        MobileContext db;

        public HomeController(MobileContext db) {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Phones.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Buy(int id) {
            ViewBag.PhoneId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Order order) {
            db.Orders.Add(order);
            db.SaveChanges();
            return "Thank you, " + order.User + ", for your order";
        }
    }
}
