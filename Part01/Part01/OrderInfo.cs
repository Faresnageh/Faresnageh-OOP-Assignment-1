using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01_oop
{
    public class OrderInfo
    {
        public OrderInfo(string paymentMethod, string currency, decimal subTotal, decimal discountAmount, decimal taxAmount, decimal totalAmount)
        {
            PaymentMethod = paymentMethod;
            Currency = currency;
            SubTotal = subTotal;
            DiscountAmount = discountAmount;
            TaxAmount = taxAmount;
            TotalAmount = totalAmount;
        }

        public string PaymentMethod { get; set; }
        public string Currency { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
