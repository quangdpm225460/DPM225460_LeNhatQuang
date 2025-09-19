namespace IteratorPattern
{
    // ConcreteAggregate: lớp quản lý danh sách sinh viên
    public class StudentCollection : IAggregate<string>
    {
        private List<string> _students = new List<string>();

        public void Add(string student)
        {
            _students.Add(student);
        }

        public int Count => _students.Count;

        public string this[int index] => _students[index];

        public IIterator<string> CreateIterator()
        {
            return new StudentIterator(this);
        }
    }
}
