using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Raer_Camp_Project_DEMO.Models;
using DataContext;

namespace Raer_Camp_Project_DEMO.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext db;

        public HomeController(DatabaseContext db) {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Phones.ToList());
        }

        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public async Task<string> Create([Bind("Name","Company","Price")]Phone phone) {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Phones.Add(phone);
                    await db.SaveChangesAsync();
                    return "Phone " + phone.Name + " " + phone.Company + " was created";
                }
                else return "All fields must be filled";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpGet]
        public IActionResult Edit(int id) {
            if (id != 0)
            {
                var phone = db.Phones.SingleOrDefault(x => x.Id == id);
                return View(phone);
            }
            else return View();
        }

        [HttpPost]
        public async Task<string> Edit([Bind("Id", "Name", "Company", "Price")]Phone phone) {
            try {
                if (ModelState.IsValid)
                {
                    db.Phones.Update(phone);
                    await db.SaveChangesAsync();
                    return "Phone " + phone.Name + " " + phone.Company + " was edited";
                }
                else return "All fields must be filled";
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }

        [HttpPost,HttpGet]
        public async Task<IActionResult> Delete(int id) {
            try {
                if (id != 0)
                {
                    var currentPhone = db.Phones.SingleOrDefault(x => x.Id == id);
                    db.Phones.Remove(currentPhone);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex) {
                ViewBag.Error = ex.Message;
            }

            return View("Index", db.Phones.ToList());

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
