using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Part01
{
    public class Order
    {
        public Order(int id, Customer customer, DateOnly date)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            ArgumentNullException.ThrowIfNull(customer);
            ArgumentOutOfRangeException.ThrowIfEqual(date, default);
            Id = id;
            Customer = customer;
            Date = date;
        }
        public int Id { get; }
        public Customer Customer { get; }
        public DateOnly Date { get; }
        public bool IsPaid { get; private set; } = false;
        private readonly List<OrderLine> _orderLines = new List<OrderLine>(20);


        public IReadOnlyCollection<OrderLine> OrderLines => _orderLines;
        public void MarkOrderPaid()
        {
            if(_orderLines.Count==0)
                throw new InvalidOperationException("Cannot pay an empty order");
            IsPaid = true;
        }
        public void AddLine(Product product, int quantity)
        {
            ArgumentNullException.ThrowIfNull(product);
            if (_orderLines.Count == 20)
                throw new ArgumentOutOfRangeException("Order cannot contain more than 20 lines");
            if (IsPaid == true)
                throw new InvalidOperationException(nameof(IsPaid));
            product.DecreaseStock(quantity);
            _orderLines.Add(new OrderLine(product, quantity));
        }
        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var line in _orderLines)
            {
                total += line.LineTotal;
            }
            if (Customer.IsVip)
            {
                total *= 0.90m;
            }
            return total;
        }
    }
}
