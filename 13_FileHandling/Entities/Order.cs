using System;
using System.Collections.Generic;
using System.Text;

namespace _13_FileHandling.Entities
{
    internal class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Order(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public double Total()
        {
            return Product.Price * Quantity;
        }
    }
}
