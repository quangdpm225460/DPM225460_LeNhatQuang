namespace IteratorPattern
{
    // Iterator interface
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
