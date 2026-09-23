using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01_oop
{
    public class AddressBuilder
    {
        public AddressBuilder(string street, string city, string country)
        {
            _street = street;
            _city = city;
            _country = country;
        }
        private readonly string _street;
        private readonly string _city;
        private readonly string _country;
        private string _state;
        private string _zipCode;
        public AddressBuilder WithState(string state)
        {
            _state = state;
            return this;
        }
        public AddressBuilder WithZipCode(string zipCode)
        {
            _zipCode = zipCode;
            return this;
        }
        public Address Build()
            => new Address(_street, _city, _state, _zipCode, _country);
    }
}
