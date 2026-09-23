using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01_oop
{
    public class Guest
    {
        public Guest(string fullName, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentNullException(nameof(fullName));
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentNullException(nameof(phoneNumber));
            Id = Guid.NewGuid();
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        public Guid Id { get; }
        public string FullName { get; }
        public string PhoneNumber { get; }
        private readonly List<Reservation> _reservations = new List<Reservation>();
        public IReadOnlyList<Reservation> Reservations => _reservations;
        public void AddReservation(Reservation reservation)
        {
            ArgumentNullException.ThrowIfNull(reservation);
            _reservations.Add(reservation);
        }
    }
}
