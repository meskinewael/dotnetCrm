using crm.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm
{
    public class CrmDbcontext:DbContext
    {
       
        public DbSet<Custemer> Custemers { get; set; }
       public DbSet<Order> Orders { get; set;  }
       public DbSet<Product> products { get; set; }
        public DbSet<OrdersLigne> OrdersLignes { get; set; }
        
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
              //optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog = CrmApp ");
              optionsBuilder.UseSqlite("Data Source=CrmDatabase.db").EnableSensitiveDataLogging();
          }
    }
}
