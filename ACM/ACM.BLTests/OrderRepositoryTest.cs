using System;
using ACM.BL;
using NUnit.Framework;

namespace ACM.Tests.ACM.BLTests
{
    public class OrderRepositoryTest
    {
        [Test]
        public void RetrieveValid()
        {
            //Arrange
            var orderRepository = new OrderRepository();

            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Today)
            };

            //Act
            var actual = orderRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.OrderDate,actual.OrderDate);
            Assert.AreEqual(expected.OrderId,actual.OrderId);
        }

        [Test]
        public void RetrieveInValid()
        {
            //Arrange
            var orderRepository = new OrderRepository();

            //Act
            var actual = orderRepository.Retrieve(0);

            //Assert
            Assert.IsNull(actual);
        }

    }
}