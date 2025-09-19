namespace IteratorPattern
{
    // Aggregate interface
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
