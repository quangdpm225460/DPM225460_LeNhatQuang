using Facade.TravelExample;
using System;

namespace DPM225460_LeNhatQuang_Example10_Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Facade
            TravelBooking travel = new TravelBooking();

            // Evaluate travel booking for customer
            Customer customer = new Customer("John Smith");
            bool success = travel.BookTrip(customer, "Paris");

            Console.WriteLine("\n" + customer.Name +
                (success ? " successfully booked a trip!" : " failed to book the trip."));

            Console.ReadKey();
        }
    }
}
