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
              var product =  new Product(productId)
                {
                   Description = "Test Product",
                   CurrentPrice = 1.0m,
                   ProductName = "Test Product"
                };

              Console.WriteLine($"Product: {product}");
              return product;
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
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
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