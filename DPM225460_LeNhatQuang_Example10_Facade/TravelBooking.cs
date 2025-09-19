namespace Facade.TravelExample
{
    /// <summary>
    /// Facade class
    /// </summary>
    public class TravelBooking
    {
        FlightBooking flight = new FlightBooking();
        HotelBooking hotel = new HotelBooking();
        CarRental car = new CarRental();

        public bool BookTrip(Customer cust, string destination)
        {
            Console.WriteLine("{0} is booking a trip to {1}\n", cust.Name, destination);

            bool booked = true;

            if (!flight.BookFlight(cust, destination))
                booked = false;
            else if (!hotel.BookHotel(cust, destination))
                booked = false;
            else if (!car.RentCar(cust, destination))
                booked = false;

            return booked;
        }
    }
}
