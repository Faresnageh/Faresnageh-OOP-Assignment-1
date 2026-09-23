using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01_oop
{
    public class OrderInfoBuilder
    {
        public OrderInfoBuilder(string paymentMethod, string currency, decimal subTotal, decimal totalAmount)
        {
            _paymentMethod = paymentMethod;
            _currency = currency;
            _subTotal = subTotal;
            _totalAmount = totalAmount;
        }
        private readonly string _paymentMethod;
        private readonly string _currency;
        private readonly decimal _subTotal;
        private readonly decimal _totalAmount;

        private decimal _discountAmount;
        private decimal _taxAmount;
        public OrderInfoBuilder WithDiscountAmount(decimal discountAmount)
        {
            _discountAmount = discountAmount;
            return this;
        }
        public OrderInfoBuilder WithTaxAmount(decimal taxAmount)
        {
            _taxAmount = taxAmount;
            return this;
        }
        public OrderInfo Build()
            => new OrderInfo(_paymentMethod, _currency, _subTotal, _discountAmount, _taxAmount, _taxAmount);
    }
}
