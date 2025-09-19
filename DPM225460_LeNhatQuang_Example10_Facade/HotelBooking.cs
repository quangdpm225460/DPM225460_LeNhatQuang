namespace Facade.TravelExample
{
    /// <summary>
    /// Subsystem B - Hotel booking
    /// </summary>
    public class HotelBooking
    {
        public bool BookHotel(Customer c, string destination)
        {
            Console.WriteLine("Booking hotel in " + destination + " for " + c.Name);
            return true;
        }
    }
}
