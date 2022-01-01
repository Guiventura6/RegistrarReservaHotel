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

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for update must be future dates";

            }
            if (checkOut <= checkIn)
            {
                return "Check-out date must be after check-in date";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null; // indica que nao possui nenhum erro.
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Room {RoomNumber}, check-in: {CheckIn:dd/MM/yyyy}" +
                $", check-out: {CheckOut:dd/MM/yyyy}, {Duration()} nights");
            return sb.ToString();
        }
    }
}
