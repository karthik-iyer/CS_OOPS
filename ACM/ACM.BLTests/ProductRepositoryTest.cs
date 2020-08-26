using System;
using ACM.BL;
using NUnit.Framework;

namespace ACM.Tests.ACM.BLTests
{
    public class ProductRepositoryTest
    {
        [Test]
        public void RetrieveValid()
        {
            //Arrange
            var productRepository = new ProductRepository();

            var expected = new Product(1)
            {
                Description = "Test Product",
                CurrentPrice = 1.0m,
                ProductName = "Test Product"
            };

            //Act
            var actual = productRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.Description,actual.Description);
            Assert.AreEqual(expected.ProductId,actual.ProductId);
            Assert.AreEqual(expected.CurrentPrice,actual.CurrentPrice);
            Assert.AreEqual(expected.ProductName,actual.ProductName);
        }

        [Test]
        public void RetrieveInValid()
        {
            //Arrange
            var productRepository = new ProductRepository();

            //Act
            var actual = productRepository.Retrieve(0);

            //Assert
            Assert.IsNull(actual);
        }

        [Test]
        public void Save_DoesNotHaveChanges_ReturnsTrue()
        {
            var product = new Product()
            {
                HasChanges = false,
                Description = "Test Product",
                CurrentPrice = 1.0m,
                ProductName = "Test Product",
                EntityState = EntityStateOption.Active,
            };
            var productrepository = new ProductRepository();
            var expected = true;

            var actual = productrepository.Save(product);

            Assert.AreEqual(expected,actual);

        }

        [Test]
        public void Save_IsNotValid_ReturnsFalse()
        {
            var product = new Product()
            {
                HasChanges = true,
                Description = "Test Product",
                CurrentPrice = 1.0m,
                EntityState = EntityStateOption.Active,
            };
            var productRepository = new ProductRepository();
            var expected = false;

            var actual = productRepository.Save(product);

            Assert.AreEqual(expected,actual);

        }
    }
}