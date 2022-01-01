using System;
using RegistrarReserva.Entities;

namespace RegistrarReserva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after " +
                    "check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
                Console.WriteLine();
            }


        }
    }
}
