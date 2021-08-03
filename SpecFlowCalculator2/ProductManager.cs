using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowCalculator2
{
    public class ProductManager
    {
        List<Product> products;
        public ProductManager()
        {
            products = new List<Product>();
        }
        public void AddToCart(Product product)
        {
            products.Add(product);
        }
        public void RemoveFromCart(Product product)
        {
            products.Remove(product);
        }

    }
}
