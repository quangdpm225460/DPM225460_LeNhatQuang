namespace Facade.TravelExample
{
    /// <summary>
    /// Subsystem A - Flight booking
    /// </summary>
    public class FlightBooking
    {
        public bool BookFlight(Customer c, string destination)
        {
            Console.WriteLine("Booking flight to " + destination + " for " + c.Name);
            return true;
        }
    }
}
