using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBWorker.dal.Entities;

namespace DBWorker.dal.EF
{
    public class ProductContext : DbContext
    {
        public DbSet<Product>? products { get; set; }

        static ProductContext()
        {
            Database.SetInitializer<ProductContext>(new StoreDbInitializer());
        }
        public ProductContext(string connectionString)
            : base(connectionString)
        {
        }

    }
}
