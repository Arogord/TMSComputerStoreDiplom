using Abststract.common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWorker.dal.EF
{
    //этот клас удалить временный представитель базы
    //public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    //{
    //    protected override void Seed(ProductContext db)
    //    {
    //        db.products.Add(new Product{ Name = "RTX4090", Description = "DDR6, 24GB, 450W", Category = "Videocard", Price = 1500M });
    //        db.products.Add(new Product { Name = "RTX4080", Description = "DDR6, 16GB, 400W", Category = "Videocard", Price = 1300M });
    //        db.products.Add(new Product { Name = "RTX3060", Description = "DDR6, 12GB, 300W", Category = "Videocard", Price = 600M });
    //        db.products.Add(new Product { Name = "RTX3080", Description = "DDR6, 16GB, 400W", Category = "Videocard", Price = 1100M });
    //        db.SaveChangesAsync();
    //    }
    //}
}
