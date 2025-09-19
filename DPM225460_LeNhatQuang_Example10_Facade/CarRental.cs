namespace Facade.TravelExample
{
    /// <summary>
    /// Subsystem C - Car rental
    /// </summary>
    public class CarRental
    {
        public bool RentCar(Customer c, string destination)
        {
            Console.WriteLine("Renting car in " + destination + " for " + c.Name);
            return true;
        }
    }
}
