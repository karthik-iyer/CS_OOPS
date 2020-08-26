using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderItem : ILog
    {
        public int OrderItemId { get; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public bool Validate()
        {
            var isValid = true;

            if (Product == null)
            {
                isValid = false;
            }

            if (Quantity < 0)
            {
                isValid = false;
            }

            if (PurchasePrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem(orderItemId);
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public override string ToString()
        {
            return $"{OrderItemId} , Product: {Product} , Quantity: {Quantity} , PurchasePrice: {PurchasePrice}";
        }

        public string Log()
        {
            return ToString();
        }
    }
}