using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Raer_Camp_Project_DEMO_WEB_API.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    }
}
