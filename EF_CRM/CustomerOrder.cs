using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRM
{
    public class CustomerOrder
    {
        public DateTime OrderDate { get; set; }
        public required string CustomerName { get; set; }
        public required string ProductName { get; set; }
    }
}
