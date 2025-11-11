namespace DesignPatterns.BehavioralPatterns.Memento
{
    public abstract class AbstractMemento<T> : IMemento<T> where T : ICloneable
    {
        private T State { get; set; }
        protected AbstractMemento(T state)
        {
            State = (T)state.Clone();
        }
        public virtual T GetState()
        {
            return State;
        }
    }
}