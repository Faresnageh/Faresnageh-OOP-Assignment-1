using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01_oop
{
    public class InvoiceBuilder
    {
        public InvoiceBuilder(int invoiceId, string customerName, string currency, decimal subTotal)
        {
            _invoiceId = invoiceId;
            _customerName = customerName;
            _currency = currency;
            _subTotal = subTotal;
        }
        private readonly int _invoiceId;
        private readonly string _customerName;
        private readonly string _currency;
        private readonly decimal _subTotal;


        private string _customerEmail;
        private string _customerPhone;
        private string _billingStreet;
        private string _billingCity;
        private string _billingState;
        private string _billingZipCode;
        private string _billingCountry;
        private string _shippingStreet;
        private string _shippingCity;
        private string _shippingState;
        private string _shippingZipCode;
        private string _shippingCountry;
        private DateOnly _orderDate;
        private string? _paymentMethod;
        private decimal _discountAmount;
        private decimal _taxAmount;
        private decimal _totalAmount;
        public InvoiceBuilder WithCustomerEmail(string customerEmail)
        {
            _customerEmail = customerEmail;
            return this;
        }
        public InvoiceBuilder WithCustomerPhone(string customerPhone)
        {
            _customerPhone = customerPhone;
            return this;
        }
        public InvoiceBuilder WithBillingStreet(string billingStreet)
        {
            _billingStreet = billingStreet;
            return this;
        }
        public InvoiceBuilder WithBillingCity(string billingCity)
        {
            _billingCity = billingCity;
            return this;
        }
        public InvoiceBuilder WithBillingState(string billingState)
        {
            _billingState = billingState;
            return this;
        }
        public InvoiceBuilder WithBillingZipCode(string billingZipCode)
        {
            _billingZipCode = billingZipCode;
            return this;
        }
        public InvoiceBuilder WithBillingCountry(string billingCountry)
        {
            _billingCountry = billingCountry;
            return this;
        }
        public InvoiceBuilder WithShippingStreet(string shippingStreet)
        {
            _shippingStreet = shippingStreet;
            return this;
        }
        public InvoiceBuilder WithShippingCity(string shippingCity)
        {
            _shippingCity = shippingCity;
            return this;
        }
        public InvoiceBuilder WithShippingState(string shippingState)
        {
            _shippingState = shippingState;
            return this;
        }
        public InvoiceBuilder WithShippingZipCode(string shippingZipCode)
        {
            _shippingZipCode = shippingZipCode;
            return this;
        }

        public InvoiceBuilder WithShippingCountry(string shippingCountry)
        {
            _shippingCountry = shippingCountry;
            return this;
        }
        public InvoiceBuilder WithOrderDate(DateOnly orderDate)
        {
            _orderDate = orderDate;
            return this;
        }
        public InvoiceBuilder WithPaymentMethod(string paymentMethod)
        {
            _paymentMethod = paymentMethod;
            return this;
        }

        public InvoiceBuilder WithDiscountAmount(decimal discountAmount)
        {
            _discountAmount = discountAmount;
            return this;
        }
        public InvoiceBuilder WithTaxAmount(decimal taxAmount)
        {
            _taxAmount = taxAmount;
            return this;
        }
        public InvoiceBuilder WithTotalAmount(decimal totalAmount)
        {
            _totalAmount = totalAmount;
            return this;
        }
        private Address _billingAddress;
        private Address _shippingAddress;
        private OrderInfo _orderInfo;
        public InvoiceBuilder WithBillingAddress(Address billingAddresss)
        {
            _billingAddress = billingAddresss;
            return this;
        }
        public InvoiceBuilder WithShippingAddress(Address shippingAddress)
        {
            _shippingAddress = shippingAddress;
            return this;
        }
        public InvoiceBuilder WithOrderInfo(OrderInfo orderInfo)
        {
            _orderInfo = orderInfo;
            return this;
        }
        public Invoice Build()
            => new Invoice(_invoiceId, _customerName, _customerEmail, _customerPhone, _billingStreet, _billingCity, _billingState, _billingZipCode, _billingCountry, _shippingStreet, _shippingCity, _shippingState, _shippingZipCode, _shippingCountry, _orderDate, _paymentMethod, _currency, _subTotal, _discountAmount, _taxAmount, _totalAmount);
    }
}