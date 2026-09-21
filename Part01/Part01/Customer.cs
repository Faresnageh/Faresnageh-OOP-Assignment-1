using System;
using System.Collections.Generic;
using System.Text;

namespace Part01
{
    public class Customer
    {
        public Customer(int id, string name, string email, string city, bool isVip)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty",nameof(name));
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email cannot be empty",nameof(email));
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City cannot be empty",nameof(city));
            Id = id;
            Name = name;
            Email = email;
            City = city;
            IsVip = isVip;
        }

        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
        public string City { get; }
        public bool IsVip { get; }
    }
}
