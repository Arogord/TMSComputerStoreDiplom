using Abststract.common.Abstract;
using Abststract.common.Entities;
using DBWorker.dal.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic.bll.Service
{
    public class BusinesLogic : IProductRepository
    {
        public DBaseforTest prod;
        public BusinesLogic()
        {
            prod = new DBaseforTest();
        }

        IEnumerable<Product> IProductRepository.Products => prod.prod;

    }
}
