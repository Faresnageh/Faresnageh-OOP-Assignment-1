using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Part01
{
    public class Product
    {
        public Product(int id, string name, decimal price, int productStock)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);
            ArgumentOutOfRangeException.ThrowIfNegative(productStock);
            Id = id;
            Name = name;
            Price = price;
            ProductStock = productStock;
        }
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public int ProductStock { get; private set; }
        public void DecreaseStock(int quantity)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(quantity);
            if (quantity > ProductStock)
                throw new InvalidOperationException("Not enough stock");
            ProductStock -= quantity;
        }

    }
}
