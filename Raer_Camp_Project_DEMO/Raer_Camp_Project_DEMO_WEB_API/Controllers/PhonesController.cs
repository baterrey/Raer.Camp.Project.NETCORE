using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataContext;

namespace Raer_Camp_Project_DEMO_WEB_API.Controllers
{
    [Produces("application/json")]
    [Route("api/Phones")]
    public class PhonesController : Controller
    {
        DatabaseContext db;

        public PhonesController(DatabaseContext db) {
            this.db = db;
        }

        //Get All Phones
        [HttpGet]
        public IEnumerable<Phone> Get() {
            return db.Phones.ToList();
        }

        //get one phone by ID
        [HttpGet("{id}")]
        public Phone Get(int id) {
            var currentPhone = db.Phones.SingleOrDefault(x => x.Id == id);
            return currentPhone;
        }

        //Save Phone In DB
        [HttpPost]
        public IEnumerable<Phone> Post([FromBody] Phone phone) {
            db.Phones.Add(phone);
            db.SaveChanges();
            //return Ok(phone);
            return db.Phones.ToList();
        }

        //Update Existing Phone
        [HttpPut]
        public IEnumerable<Phone> Put([FromBody] Phone phone) {
            if (!db.Phones.Any(x => x.Id == phone.Id)) {
                //return NotFound();
            }
            db.Phones.Update(phone);
            db.SaveChanges();
            return db.Phones.ToList();
        }

        //Delete Existing Phone
        [HttpDelete("{id}")]
        public IEnumerable<Phone> Delete(int id) {
            var phone = db.Phones.FirstOrDefault(x => x.Id == id);
            if (phone != null) {
                db.Phones.Remove(phone);
                db.SaveChanges();
            }
            return db.Phones.ToList();
        }

    }
}