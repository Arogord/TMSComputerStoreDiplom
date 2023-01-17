using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abststract.common.Entities;
using Microsoft.EntityFrameworkCore;


namespace DBWorker.dal.EF
{
    public class ProductContext : DbContext
    {
        public DbSet<Product>? Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TMSComputerStore;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer(Config.ConnectionString);

        }

    }
}
