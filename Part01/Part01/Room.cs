using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01_oop
{
    public class Room
    {
        public Room(int number, RoomType type, decimal nightRate)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(number);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(nightRate);
            Number = number;
            Type = type;
            NightRate = nightRate;
            UnderMaintenance = false;
        }

        public int Number { get; }
        public RoomType Type { get; }
        public decimal NightRate { get; private set; }
        public bool UnderMaintenance { get; private set; }
        public void ChangeNightRate(decimal NewNightRate)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(NewNightRate);
            NightRate = NewNightRate;
        }
        public void StartMaintenance()
        {
            UnderMaintenance = true;
        }
        public void EndMaintenance()
        {
            UnderMaintenance = false;
        }



        private readonly List<Reservation> _reservations = new();

        public void AddReservation(Reservation reservation)
        {
            ArgumentNullException.ThrowIfNull(reservation);

            if (reservation.Room != this)
                throw new InvalidOperationException(
                    "Reservation belongs to another room");

            foreach (var existingReservation in _reservations)
            {
                if (existingReservation.ReservationStatus == ReservationStatus.Cancelled ||
                    existingReservation.ReservationStatus == ReservationStatus.CheckedOut)
                {
                    continue;
                }
                bool overlap =
                    reservation.InDate < existingReservation.OutDate &&
                    reservation.OutDate > existingReservation.InDate;
                if (overlap)
                {
                    throw new InvalidOperationException(
                        "Room is already reserved in this period");
                }
            }
            _reservations.Add(reservation);
        }
    }
}