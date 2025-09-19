namespace IteratorPattern
{
    // ConcreteIterator
    public class StudentIterator : IIterator<string>
    {
        private StudentCollection _collection;
        private int _current = 0;

        public StudentIterator(StudentCollection collection)
        {
            _collection = collection;
        }

        public bool HasNext()
        {
            return _current < _collection.Count;
        }

        public string Next()
        {
            return _collection[_current++];
        }
    }
}
