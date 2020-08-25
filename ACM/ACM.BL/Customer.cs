using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        private string _firstName;

        private string _lastName;

        private string _email;

        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string EmailAddress { get; set; }

        public string HomeAddress { get; set; }

        public string WorkAddress { get; set; }

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

        public Customer Retrieve(int customerId)
        {
            return new Customer(customerId);
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public void Save()
        {

        }
    }
}