using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public DateTimeOffset? OrderDate { get; set; }

        public Order()
        {

        }

        public int OrderId { get;}

        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public bool Validate()
        {
            return !(OrderDate == null);
        }

        public Order Retrieve(int orderId)
        {
            return new Order(orderId);
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public void Save()
        {

        }
    }
}