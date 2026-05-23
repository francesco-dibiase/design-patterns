namespace DesignPatterns.BehavioralPatterns.Memento
{
      public class CareTaker<T> where T : ICloneable
      {
            public T Originator { get; private set; }
            private Stack<Memento<T>> History { get; set; } = new();
            public CareTaker(T originator)
            {
                  Originator = originator;
            }
            public void SetMemento()
            {
                  History.Push(new Memento<T>((T)Originator.Clone()).PrintTimestamp(Utility.MementoAction.Pushed));
            }
            public void Undo()
            {
                  if (History.Count <= 0) return;
                  Originator = History.Pop().PrintTimestamp(Utility.MementoAction.Popped).GetState();
            }
      }
}
