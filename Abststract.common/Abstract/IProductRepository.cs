using Abststract.common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abststract.common.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }  
    }
}
