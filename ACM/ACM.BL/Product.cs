using System.Collections.Generic;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public int ProductId { get; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal? CurrentPrice { get; set; }

        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Description))
            {
                isValid = false;
            }

            if (CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}