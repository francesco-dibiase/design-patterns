namespace DesignPatterns.BehavioralPatterns.Iterator
{
    public class Iterator<T> : IIterator<T>
    {
        private readonly IList<T> _collection;
        public int Index { get; private set; } = 0;

        public Iterator(IList<T> collection)
        {
            _collection = collection;
        }
        public T CurrentItem()
        {
            return _collection[Index];
        }

        public T First()
        {
            if (_collection.Count > 0)
            {
                Index = 0;
                return _collection[0];
            }
            else
            {
                throw new InvalidOperationException($"{nameof(_collection)} is empty");
            }

        }

        public bool IsDone()
        {
            return Index >= _collection.Count;
        }

        public T Next()
        {
            if (Index >= _collection.Count) throw new InvalidOperationException("No more elements to iterate.");

            return _collection[Index++];
        }
    }
}