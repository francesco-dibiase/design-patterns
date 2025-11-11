namespace DesignPatterns.BehavioralPatterns.Memento
{
    public class Memento<T> : AbstractMemento<T> where T : ICloneable
    {
        public DateTime _Timestamp { get; private set; }
        public Memento(T state) : base(state)
        {
            _Timestamp = DateTime.Now;
        }
        public Memento<T> PrintTimestamp()
        {
            Console.WriteLine($"Timestamp of this snapshot: {this._Timestamp.ToLongTimeString()}\n");
            return this;
        }
    }
}