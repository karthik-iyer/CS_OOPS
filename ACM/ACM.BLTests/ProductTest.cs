using ACM.BL;
using NUnit.Framework;

namespace ACM.Tests.ACM.BLTests
{
    public class ProductTest
    {
        [Test]
        public void Validate_EmptyProductName()
        {
            //Arrange
            var product = new Product()
            {
                Description = "Test",
                CurrentPrice = 1.0m,
            };

            //Act
            var expected = false;
            var actual = product.Validate();

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Validate_EmptyDescription()
        {
            //Arrange
            var product = new Product()
            {
                ProductName = "Test",
                CurrentPrice = 1.0m,
            };

            //Act
            var expected = false;
            var actual = product.Validate();

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Validate_InvalidPrice()
        {
            //Arrange
            var product = new Product()
            {
                CurrentPrice = null,
                Description = "test",
                ProductName = "test"
            };

            //Act
            var expected = false;
            var actual = product.Validate();

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}