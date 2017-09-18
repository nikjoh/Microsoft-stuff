using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryProject.Models
{
    public class DataManager
    {
        private static List<Customer> customers = new List<Customer>
        {
            new Customer {Id = 1, Name = "Coop", City = "Skellefteå" },
            new Customer {Id = 2, Name = "Ica", City = "Stockholm"},
            new Customer {Id = 3, Name = "Lidl", City = "Örnsköldsvik"},
            new Customer {Id = 4, Name = "Hemköp", City = "Sundsvall"},
            new Customer {Id = 5, Name = "Domus", City = "Gävle"}
        };

        public static IndexVM[] GetCustomers()
        {
            return customers.Select(c => new IndexVM
            {
                Id = c.Id,
                Name = c.Name,
                City = c.City

            }).ToArray();
        }

        internal static IndexVM GetCustomer(int id)
        {
            return customers.Where(c => c.Id == id)
                .Select(c => new IndexVM
                {
                    Id = c.Id,
                    Name = c.Name,
                    City = c.City

                }).SingleOrDefault();
        }
    }
}
