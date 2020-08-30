using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.Model
{
    public class OrdersLigne
    {
        public long id { get; set; }
        public long Products_id { get; set; }
        public  int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
