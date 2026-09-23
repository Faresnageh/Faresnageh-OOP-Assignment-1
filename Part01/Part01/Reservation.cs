using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment01_oop
{
    public class Reservation
    {
        public Reservation(DateOnly inDate, DateOnly outDate, Room room)
        {
            if (outDate <= inDate)
                throw new Exception("Out date must be after in date");
            ArgumentNullException.ThrowIfNull(room);
            if (room.UnderMaintenance == true)
                throw new Exception("Room is under maintenance");
            ReservationStatus = ReservationStatus.Pending;
            Id = Guid.NewGuid();
            InDate = inDate;
            OutDate = outDate;
            Room = room;
            room.AddReservation(this);
        }

        public Guid Id { get; }
        public DateOnly InDate { get; }
        public DateOnly OutDate { get; }
        public Room Room { get; }
        public ReservationStatus ReservationStatus { get; private set; }
        public decimal TotalCost()
        {
            return Room.NightRate * ((OutDate.DayNumber - InDate.DayNumber));
        }
        public void Confirm()
        {
            if (ReservationStatus != ReservationStatus.Pending)
                throw new InvalidOperationException("Only pending reservation can be confirmed");

            ReservationStatus = ReservationStatus.Confirmed;
        }
        public void CheckIn()
        {
            if (ReservationStatus != ReservationStatus.Confirmed)
                throw new InvalidOperationException("Reservation must be confirmed before checkIn");

            ReservationStatus = ReservationStatus.CheckedIn;
        }
        public void CheckOut()
        {
            if (ReservationStatus != ReservationStatus.CheckedIn)
                throw new InvalidOperationException("Reservation must be checked in before checkOut");

            ReservationStatus = ReservationStatus.CheckedOut;
        }
        public void Cancel()
        {
            if (ReservationStatus != ReservationStatus.Pending && ReservationStatus != ReservationStatus.Confirmed)
            {
                throw new InvalidOperationException("Only pending or confirmed reservation can be cancelled");
            }
            ReservationStatus = ReservationStatus.Cancelled;
        }
    }
}
