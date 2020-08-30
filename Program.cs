using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crm.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace crm
{
    public class Program
    {
       // private static CrmDbcontext Context = new CrmDbcontext();
        public static void Main(string[] args)
        {
            /*  Context.Database.EnsureCreated();
               AddUser();
               GetData();*/

            CreateHostBuilder(args).Build().Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
        /*   public static void GetData()
           {
               var result = Context.Custemers.ToList();
            foreach(var Res in result)
               {
                   Console.WriteLine(Res.id);
               }

           }
           public static  void AddUser()
           {
               var result = new Custemer { name = "wael", lastname = "meskine", phone = "sert", email = "dre", adresse = "ekmj" };
               Context.Custemers.Add(result);
               Context.SaveChanges();
           }*/
    }
}
