using System;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve a Order by OrderId
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {

            if (productId <= 0) return null;

            if (productId == 1)
            {
                return new Product(productId)
                {
                   Description = "Test Product",
                   CurrentPrice = 1.0m,
                   ProductName = "Test Product"
                };
            }

            return null;
        }

        /// <summary>
        /// Saves the current Order
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Save(Product product)
        {
            return true;
        }
    }
}