using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public DateTimeOffset? OrderDate { get; set; }

        public int OrderId { get;}

        public int CustomerId { get; set; }

        public int  ShippingAddressId { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Order():this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public bool Validate()
        {
            return !(OrderDate == null);
        }
    }
}