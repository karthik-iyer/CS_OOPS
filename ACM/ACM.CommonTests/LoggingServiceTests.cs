using System;
using System.Collections.Generic;
using ACM.BL;
using ACM.Common;
using NUnit.Framework;

namespace ACM.CommonTests
{
    public class LoggingServiceTests
    {
        [Test]
        public void WriteToFileWritesAllObjectsToConsole()
        {
            //Arrange
            var product = new Product()
            {
                CurrentPrice = null,
                Description = "test",
                ProductName = "test"
            };

            var order = new Order
            {
                OrderDate = new DateTimeOffset(DateTime.Today),
                OrderItems = new List<OrderItem>
                {
                    new OrderItem
                    {
                        Quantity = 1,
                        Product = new Product(),
                        PurchasePrice = 1.0m
                    },
                    new OrderItem
                    {
                        Quantity = 1,
                        Product = new Product(),
                        PurchasePrice = 2.0m
                    },
                    new OrderItem
                    {
                        Quantity = 1,
                        Product = new Product(),
                        PurchasePrice = 3.0m
                    }
                }
            };

            var customer = new Customer(1)
            {
                FirstName = "Joe",
                LastName = "Smith",
                AddressList = new List<Address>
                {
                    new Address
                    {
                        StreetLine1 = "123 street",
                        City = "Houston",
                        State = "Texas",
                        PostalCode = "77007",
                        AddressType = "Home"
                    },
                    new Address
                    {
                        StreetLine1 = "1223 street",
                        City = "Houston",
                        State = "Texas",
                        PostalCode = "77007",
                        AddressType = "Home"
                    },
                    new Address
                    {
                        StreetLine1 = "1234 street",
                        City = "Houston",
                        State = "Texas",
                        PostalCode = "77007",
                        AddressType = "Home"
                    },
                }
            };

            var itemsToLog = new List<ILog>()
            {
                product,
                order,
                customer
            };

            //Act and Assert
            LoggingService.WriteToFile(itemsToLog);
        }
    }
}