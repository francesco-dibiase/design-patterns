namespace DesignPatterns.BehavioralPatterns.Memento
{
    public class CareTaker<T> where T : ICloneable
    {
        public T Originator { get; set; }
        private Stack<Memento<T>> _History { get; set; } = new();
        public CareTaker(T originator)
        {
            Originator = originator;
        }
        public void SetMemento()
        {
            _History.Push(new Memento<T>((T)Originator.Clone()));
        }
        public void Undo()
        {
            if (_History.Count <= 0) return;
            Originator = _History.Pop().PrintTimestamp().GetState();
        }
    }
}