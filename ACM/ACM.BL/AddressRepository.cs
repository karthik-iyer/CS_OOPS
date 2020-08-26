using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieves an Address
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = "Home";
                address.StreetLine1 = "123 Street";
                address.City = "Houston";
                address.State = "Texas";
                address.Country = "US";
                address.PostalCode = "99999";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            var address = new Address(1)
            {
               StreetLine1 = "123 Street",
               AddressType = "Home",
               City = "Houston",
               State = "Texas",
               Country = "US",
               PostalCode = "99999"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                StreetLine1 = "1233 Street",
                AddressType = "Work",
                City = "Houston",
                State = "Texas",
                Country = "US",
                PostalCode = "99999"
            };
            addressList.Add(address);

            address = new Address(3)
            {
                StreetLine1 = "1133 Street",
                AddressType = "Home",
                City = "Houston",
                State = "Texas",
                Country = "US",
                PostalCode = "99999"
            };
            addressList.Add(address);

            return addressList;
        }


        /// <summary>
        /// Saves an Address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        //Insert
                    }
                    else
                    {
                        //Update
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}