using System;
using System.Collections.Generic;
using System.Text;

namespace Part01
{
    public class OrderLine
    {
        public OrderLine(Product product, int quantity)
        {
            ArgumentNullException.ThrowIfNull(product);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(quantity);
            Product = product;
            Quantity = quantity;
            UnitPrice = product.Price;
        }

        public Product Product { get; }
        public int Quantity { get; }
        public decimal UnitPrice { get; }
        public decimal LineTotal => UnitPrice * Quantity;

    }
}
