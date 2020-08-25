using System;
using ACM.BL;
using NUnit.Framework;

namespace ACM.Tests.ACM.BLTests
{
    public class OrderTest
    {
        [Test]
        public void Validate_InvalidOrderDate_ValidationFails()
        {
            var order = new Order
            {
                OrderDate = default
            };

            const bool expected = false;

            var actual = order.Validate();

            Assert.AreEqual(expected,actual);

        }
    }
}