using ACM.BL;
using NUnit.Framework;

namespace ACM.Tests.ACM.BLTests
{
    public class CustomerTest
    {
        public const int CustomerId = 1;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FullName_ValidTest()
        {
            //Arrange
            var customer = new Customer(CustomerId)
            {
                FirstName = "Joe",
                LastName = "Smith"
            };

            //Act
            var expected = "Smith, Joe";
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void FullName_EmptyFirstName()
        {
            //Arrange
            var customer = new Customer(CustomerId)
            {
                LastName = "Smith"
            };

            //Act
            var expected = "Smith";
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void FullName_EmptyLasttName()
        {
            //Arrange
            var customer = new Customer(CustomerId)
            {
                FirstName = "Joe",
            };

            //Act
            var expected = "Joe";
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void InstanceCount_returnsValue()
        {
            //Arrange
            var customer = new Customer(CustomerId)
            {
                FirstName = "Joe",
            };
            Customer.InstanceCount += 1;

            var customer2 = new Customer(CustomerId)
            {
                FirstName = "Joe1",
            };
            Customer.InstanceCount += 1;

            var customer3 = new Customer(CustomerId)
            {
                FirstName = "Jo2",
            };
            Customer.InstanceCount += 1;

            //Act
            const int expected = 3;
            var actual = Customer.InstanceCount;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Validate_GivenMissingLastName()
        {
            var cust = new Customer(CustomerId)
            {
                EmailAddress = "Test@test.com"
            };

            const bool actual = false;

            var expected = cust.Validate();

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Validate_GivenMissingEmailAddress()
        {
            var cust = new Customer(CustomerId)
            {
                LastName = "Test Last"
            };

            const bool actual = false;

            var expected = cust.Validate();

            Assert.AreEqual(expected,actual);
        }
    }
}