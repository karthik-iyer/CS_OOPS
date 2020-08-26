using System.Collections.Generic;
using ACM.BL;
using FluentAssertions;
using NUnit.Framework;

namespace ACM.Tests.ACM.BLTests
{
    public class CustomerRepositoryTest
    {

        [Test]
        public void RetrieveValid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                FirstName = "Test First",
                LastName = "Test Last",
                EmailAddress = "Test@test.com",
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId,actual.CustomerId);
        }

        [Test]
        public void RetrieveInValid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();

            //Act
            var actual = customerRepository.Retrieve(0);

            //Assert
            Assert.IsNull(actual);
        }

        [Test]
        public void RetrieveWithAddressListValid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                FirstName = "Test First",
                LastName = "Test Last",
                EmailAddress = "Test@test.com",
                AddressList = new List<Address>()
                {
                    new Address(1)
                    {
                        StreetLine1 = "123 Street",
                        AddressType = "Home",
                        City = "Houston",
                        State = "Texas",
                        Country = "US",
                        PostalCode = "99999"
                    },
                    new Address(2)
                    {
                        StreetLine1 = "1233 Street",
                        AddressType = "Work",
                        City = "Houston",
                        State = "Texas",
                        Country = "US",
                        PostalCode = "99999"
                    },
                    new Address(3)
                    {
                        StreetLine1 = "1133 Street",
                        AddressType = "Home",
                        City = "Houston",
                        State = "Texas",
                        Country = "US",
                        PostalCode = "99999"
                    }
                }

            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId,actual.CustomerId);
            actual.AddressList.Should().BeEquivalentTo(expected.AddressList);
        }


    }
}