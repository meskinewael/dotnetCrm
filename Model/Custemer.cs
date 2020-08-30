using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.Model
{
    public class Custemer
    {
       public long id { get; set; }
       public string name { get; set; }
       public string lastname { get; set; }
       public string phone { get; set; }
       public string email { get; set; }
       public string adresse { get; set; }
       public IList<Order> Orders { get; set; }



    }
}
