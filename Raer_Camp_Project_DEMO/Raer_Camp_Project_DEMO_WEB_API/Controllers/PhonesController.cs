using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Raer_Camp_Project_DEMO_WEB_API.Models;

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

        [HttpGet]
        public IEnumerable<Phone> Get() {
            return db.Phones.ToList();
        }
    }
}