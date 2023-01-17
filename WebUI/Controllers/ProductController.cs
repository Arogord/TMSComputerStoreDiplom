using Abststract.common.Abstract;
using Abststract.common.Entities;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int pageSize = 4;
        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult List(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel()
            {
                Products = repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(prod => prod.ProductID),
                CurrentCategory = category
            };

            return View(model);
        }
    }
}
