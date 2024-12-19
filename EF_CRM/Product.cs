using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRM
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public float Price { get; set; }
        public string? Color { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}
