using Abststract.common.Abstract;
using Abststract.common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWorker.dal.EF
{
    public class ProductRepository : IProductRepository
    {
        ProductContext context = new ProductContext();
        public IEnumerable<Product>? Products
        {
            get { return context.Products; }
        }
    }
}
