using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Raer_Camp_Project_DEMO.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string User { get; set; }

        public string Address { get; set; }

        public string ConcatPhone { get; set; }

        public int PhoneId { get; set; }

        public Phone Phone { get; set; }


    }
}
