using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01_oop
{
    public class Invoice
    {
        public Invoice(int invoiceId, string customerName, string customerEmail, string customerPhone, string billingStreet, string billingCity, string billingState, string billingZipCode, string billingCountry, string shippingStreet, string shippingCity, string shippingState, string shippingZipCode, string shippingCountry, DateOnly orderDate, string paymentMethod, string currency, decimal subTotal, decimal discountAmount, decimal taxAmount, decimal totalAmount)
        {
            InvoiceId = invoiceId;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            CustomerPhone = customerPhone;
            BillingStreet = billingStreet;
            BillingCity = billingCity;
            BillingState = billingState;
            BillingZipCode = billingZipCode;
            BillingCountry = billingCountry;
            ShippingStreet = shippingStreet;
            ShippingCity = shippingCity;
            ShippingState = shippingState;
            ShippingZipCode = shippingZipCode;
            ShippingCountry = shippingCountry;
            OrderDate = orderDate;
            PaymentMethod = paymentMethod;
            Currency = currency;
            SubTotal = subTotal;
            DiscountAmount = discountAmount;
            TaxAmount = taxAmount;
            TotalAmount = totalAmount;
        }

        public int InvoiceId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string BillingStreet { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZipCode { get; set; }
        public string BillingCountry { get; set; }
        public string ShippingStreet { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZipCode { get; set; }
        public string ShippingCountry { get; set; }
        public DateOnly OrderDate { get; set; }
        public string PaymentMethod { get; set; }
        public string Currency { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
