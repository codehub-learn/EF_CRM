using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRM
{
    public class Customer
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public List<Order> Orders { get; set; } = new();

        public void CreateCustomer(string first, string last, string tel, string email)
        {
            Customer cust = new Customer()
            { 
                FirstName = first, 
                LastName = last, 
                Email = email, 
                Telephone = tel 
            };   
        }
    }
}
