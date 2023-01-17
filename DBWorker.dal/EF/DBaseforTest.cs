using Abststract.common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWorker.dal.EF
{

    //этот клас удалится
    public class DBaseforTest
    {
        public List<Product> prod= new List<Product>();
        public DBaseforTest() 
        {
            prod.Add(new Product { Name = "RTX4090", Description = "DDR6, 24GB, 450W", Category = "Videocard", Price = 1500M });
            prod.Add(new Product { Name = "RTX4080", Description = "DDR6, 16GB, 400W", Category = "Videocard", Price = 1300M });
            prod.Add(new Product { Name = "RTX3060", Description = "DDR6, 12GB, 300W", Category = "Videocard", Price = 600M });
            prod.Add(new Product { Name = "RTX3080", Description = "DDR6, 16GB, 400W", Category = "Videocard", Price = 1100M });
        }
        
    }
}
