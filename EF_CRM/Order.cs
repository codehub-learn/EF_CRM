﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRM
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public required Customer Customer { get; set; }
        public required Product Product { get; set; }
    }
}
