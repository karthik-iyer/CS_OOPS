namespace ACM.BL
{
    public class CustomerRepository
    {

        /// <summary>
        /// Retrive a Customer by CustomerId
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {

            if (customerId <= 0) return null;

            if (customerId == 1)
            {
                return new Customer(customerId)
                {
                    FirstName = "Test First",
                    LastName = "Test Last",
                    EmailAddress = "Test@test.com",
                };
            }

            return null;
        }

        /// <summary>
        /// Saves the current Customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}