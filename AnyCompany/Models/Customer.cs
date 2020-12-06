using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AnyCompany
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }

        public int Id { get; set; }
        public string Country { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
