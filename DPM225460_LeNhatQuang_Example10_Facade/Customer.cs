namespace Facade.TravelExample
{
    /// <summary>
    /// Customer class
    /// </summary>
    public class Customer
    {
        public string Name { get; private set; }

        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
