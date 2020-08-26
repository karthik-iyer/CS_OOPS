using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer():this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public string FirstName { get; set; }

        public int CustomerType { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string EmailAddress { get; set; }

        public List<Address> AddressList { get; set; }

        public int CustomerId { get;}

        public string FullName
        {
            get
            {
                var fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            var isValid = !string.IsNullOrWhiteSpace(LastName);

            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}