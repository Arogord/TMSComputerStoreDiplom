using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository;
using TMSComputerStore.Areas.Admin.Controllers;
//using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;


namespace UnitTests
{
    [TestClass]
    public class CategoriesControllerTest
    {

        [TestMethod]
        //[Fact]
        public void GetAllCategory2()
        {

            var data = new List<Category>()
            {
                new Category{Id = 1, Title = "Videocard"},
                new Category{Id = 2, Title = "Processor"},
                new Category{Id = 3, Title = "Motherboard"},
            }.AsQueryable();

            // Arrange
            var mockSet = new Mock<DbSet<Category>>();
            mockSet.As<IQueryable<Category>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(() => data.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(m => m.Categories).Returns(mockSet.Object);
            var service = new CategoriesController(mockContext.Object);

            // Act
            var result = service.Index();


            // Assert

            Assert.IsInstanceOfType<ViewResult>(result);
            //var viewResult = Assert.IsType<ViewResult>(result);
            //var model = Assert.IsAssignableFrom<IEnumerable<Category>>(viewResult.Model);
            //Assert.Equal(data.Count(), model.Count());

        }


    }
    
}

