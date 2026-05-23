namespace DesignPatterns.BehavioralPatterns.Iterator
{
      public class Iterator<T>(IList<T> collection) : IIterator<T>
      {
            private readonly IList<T> Collection = collection;
            public int Index { get; private set; } = 0;

            public T CurrentItem()
            {
                  Console.WriteLine($"[ -- ]\tCurrent item on the list: {Collection[Index]}");
                  return Collection[Index];
            }

            public T? First()
            {
                  if (Collection.Count > 0)
                  {
                        Index = 0;
                        return Collection[0];
                  }
                  else
                  {
                        return default;
                  }

            }

            public bool IsDone()
            {
                  return Index >= Collection.Count;
            }

            public T Next()
            {
                  if (Index >= Collection.Count) throw new InvalidOperationException("No more elements to iterate.");
                  return Collection[Index++];
            }

            public T Previous()
            {
                  if (Index <= 0) return Collection[Index];
                  return Collection[--Index];
            }
      }
}
