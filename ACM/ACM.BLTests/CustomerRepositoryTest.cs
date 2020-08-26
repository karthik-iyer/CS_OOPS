using ACM.BL;
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

    }
}