using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.Model
{
    public class Order
    {
        public long Id { get; set; }
        public string OrderPlace { get; set; }
        public int  Number { get; set; }
        public Custemer Custemer { get; set; }

    }
}
