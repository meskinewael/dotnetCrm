using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.Model
{
    public class Product
    {
        public long id {get; set; }
        public string Name { get; set;  }
        public string Type { get; set;  }
        public IList<OrdersLigne> OrdersLignes { get; set; }
    }
}
