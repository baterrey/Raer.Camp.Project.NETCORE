using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Raer_Camp_Project_DEMO.Models
{
    public static class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider) {
            var context = serviceProvider.GetService<MobileContext>();

            if (!context.Phones.Any()) {
                context.Phones.AddRange(
                    new Phone {
                        Name = "IPhone 6S",
                        Company = "Apple",
                        Price = 600
                    },
                    new Phone {
                        Name = "Sumsung Galaxy Edge",
                        Company = "Sumsung",
                        Price = 550
                    },
                    new Phone
                    {
                        Name = "Lumia 950",
                        Company = "Microsoft",
                        Price = 500
                    }
                    );
                context.SaveChanges();
            }


        }
    }
}
