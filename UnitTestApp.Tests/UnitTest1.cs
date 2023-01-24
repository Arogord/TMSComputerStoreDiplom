//using Abststract.common.Abstract;
//using Abststract.common.Entities;
//using WebUI.Controllers;
//using Moq;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
////using System.Web.Mvc;
//using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Web.Mvc;
//using WebUI.Models;
//using Xunit;

namespace UnitTestApp.Tests
{
    //[TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        public void Can_Paginate()
        {
        //    // Организация (arrange)
        //    Mock<IProductRepository> mock = new Mock<IProductRepository>();
        //    mock.Setup(m => m.Products).Returns(new List<Product>
        //    {
        //        new Product { ProductID = 1, Name = "Videocard1"},
        //        new Product { ProductID = 2, Name = "Videocard2"},
        //        new Product { ProductID = 3, Name = "Processor3"},
        //        new Product { ProductID = 4, Name = "Ram4"},
        //        new Product { ProductID = 5, Name = "HDD5"}
        //    });
        //    ProductController controller = new ProductController(mock.Object);
        //    controller.pageSize = 3;

        //    // Действие (act)
        //    IEnumerable<Product> result = (IEnumerable<Product>)controller.List("Processor",2).Model;

        //    // Утверждение (assert)
        //    List<Product> products = result.ToList();
        //    Assert.IsTrue(products.Count == 2);
        //    Assert.AreEqual(products[0].Name, "Игра4");
        //    Assert.AreEqual(products[1].Name, "Игра5");

        //}

        //[TestMethod]
        //public void Can_Filter_Games()
        //{
        //    // Организация (arrange)
        //    Mock<IProductRepository> mock = new Mock<IProductRepository>();
        //    mock.Setup(m => m.Products).Returns(new List<Product>
        //     {
        //       new Product { ProductID = 1, Name = "Product1", Category="Cat1"},
        //       new Product { ProductID = 2, Name = "Product2", Category="Cat2"},
        //       new Product { ProductID = 3, Name = "Product3", Category="Cat1"},
        //       new Product { ProductID = 4, Name = "Product4", Category="Cat2"},
        //       new Product { ProductID = 5, Name = "Product5", Category="Cat3"}
        //     });
        //    ProductController controller = new ProductController(mock.Object);
        //    controller.pageSize = 3;

        //    // Action
        //    List<Product> result = ((ProductsListViewModel)controller.List("Cat2", 1).Model)
        //        .Products.ToList();

        //    // Assert
        //    Assert.AreEqual(result.Count(), 2);
        //    Assert.IsTrue(result[0].Name == "Product" && result[0].Category == "Cat2");
        //    Assert.IsTrue(result[1].Name == "Product4" && result[1].Category == "Cat2");
        }



    }
}
