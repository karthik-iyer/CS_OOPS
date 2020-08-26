using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve a Order by OrderId
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {

            if (orderId <= 0) return null;

            if (orderId == 1)
            {
                return new Order(orderId)
                {
                    OrderDate = new DateTimeOffset(DateTime.Today)
                };
            }

            return null;
        }

        /// <summary>
        /// Saves the current Order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
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