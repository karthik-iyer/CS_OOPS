using ACM.BL;
using NUnit.Framework;

namespace ACM.Tests.ACM.BLTests
{
    public class AddressTest
    {
        [Test]
        public void Validate_StreetLineEmpty_ValidationFails()
        {
            var address = new Address
            {
                City = "Houston",
                State = "Texas",
                PostalCode = "77007",
                Country = "United States",
                AddressType = "Home"
            };

            var expected = false;

            var actual = address.Validate();

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Validate_CityEmpty_ValidationFails()
        {
            var address = new Address
            {
                StreetLine1 = "123 street",
                State = "Texas",
                PostalCode = "77007",
                Country = "United States",
                AddressType = "Home"
            };

            var expected = false;

            var actual = address.Validate();

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Validate_StateEmpty_ValidationFails()
        {
            var address = new Address
            {
                StreetLine1 = "123 street",
                City = "Houston",
                PostalCode = "77007",
                Country = "United States",
                AddressType = "Home"
            };

            var expected = false;

            var actual = address.Validate();

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Validate_CountryEmpty_ValidationFails()
        {
            var address = new Address
            {
                StreetLine1 = "123 street",
                City = "Houston",
                State = "Texas",
                PostalCode = "77007",
                AddressType = "Home"
            };

            var expected = false;

            var actual = address.Validate();

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Validate_PostalCodeEmpty_ValidationFails()
        {
            var address = new Address
            {
                StreetLine1 = "123 street",
                City = "Houston",
                State = "Texas",
                Country = "United States",
                AddressType = "Home"
            };

            var expected = false;

            var actual = address.Validate();

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Validate_AddressTypeEmpty_ValidationFails()
        {
            var address = new Address
            {
                StreetLine1 = "123 street",
                City = "Houston",
                State = "Texas",
                PostalCode = "77007",
                Country = "United States",
            };

            var expected = false;

            var actual = address.Validate();

            Assert.AreEqual(expected,actual);
        }
    }
}