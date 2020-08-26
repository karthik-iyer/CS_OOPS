using System;
using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public class Order : EntityBase, ILog
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
        public override bool Validate()
        {
            return !(OrderDate == null);
        }

        public string Log() => $" Status: {EntityState.ToString()} , {OrderId} : {OrderDate} , { string.Concat(OrderItems.Select(x => x.ToString() + Environment.NewLine))}";
    }
}