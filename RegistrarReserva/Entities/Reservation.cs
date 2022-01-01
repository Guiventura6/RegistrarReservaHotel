using System;
using System.Text;

namespace RegistrarReserva.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Room {RoomNumber}, check-in: {CheckIn:dd/MM/yyyy}" +
                $"check-out: {CheckOut:dd//MM/yyyy}, {Duration()} nights");
            return sb.ToString();
        }
    }
}
