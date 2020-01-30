using System;
using MentalBilisim.Northwind.Business.Concrete.Managers;
using MentalBilisim.Northwind.DataAccess.Abstract;
using MentalBilisim.Northwind.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentValidation;
using Moq;

namespace MentalBilisi.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock < IProductDal > mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);
            productManager.Add(new Product());
        }
 }
}
