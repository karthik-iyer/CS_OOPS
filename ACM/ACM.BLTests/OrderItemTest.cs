using ACM.BL;
using NUnit.Framework;

namespace ACM.Tests.ACM.BLTests
{
    public class OrderItemTest
    {
        [Test]
        public void Validate_InvalidProduct_DoeNotValidate()
        {
            var orderItem = new OrderItem();

            const bool expected = false;

            var actual = orderItem.Validate();

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Validate_InvalidQuantity_DoeNotValidate()
        {
            var orderItem = new OrderItem
            {
                Quantity = -1,
                Product = new Product(),
                PurchasePrice = 1.0m
            };

            const bool expected = false;

            var actual = orderItem.Validate();

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Validate_InvalidPurchasePrice_DoeNotValidate()
        {
            var orderItem = new OrderItem
            {
                Quantity = 1,
                Product = new Product(),
                PurchasePrice = null
            };

            const bool expected = false;

            var actual = orderItem.Validate();

            Assert.AreEqual(expected,actual);
        }
    }
}