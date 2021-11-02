using Moq;
using MVPConf.Application.Models;
using MVPConf.Application.Repositories.Interfaces;
using MVPConf.Application.Services;
using MVPConf.Application.Services.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace MVPConf.Application.Test.Services
{
    public class ProductServiceTest
    {
        private readonly Mock<IProductRepository> _productRepositoryMock;
        private readonly IProductService _productService;

        public ProductServiceTest()
        {
            _productRepositoryMock = new Mock<IProductRepository>();
            _productService = new ProductService(_productRepositoryMock.Object);
        }

        [Test]
        public void GetAll_WithoutProducts_ReturnNull()
        {
            // Arrange
            // Act
            var result = _productService.GetAll();

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void GetAll_WithProducts_ReturnProducts()
        {
            // Arrange
            var products = new List<Product>();
            products.Add(new Product(1, "name", "description", 0));
            _productRepositoryMock
                .Setup(x => x.GetAll())
                .Returns(products);

            // Act
            var result = _productService.GetAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, products.Count);
        }
    }
}