using Microsoft.EntityFrameworkCore;
using Sales.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Concrete
{

    public class SalesDbSabahContext : DbContext
    {
        public SalesDbSabahContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-OVE5E20\\SQLEXPRESS; Database=SalesDbSabah; Trusted_Connection=true;");

        //}

    }

}
