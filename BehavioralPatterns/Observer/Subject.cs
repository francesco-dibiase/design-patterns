using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    public class Subject : ISubject
    {
        private List<IObserver> _Observers = new List<IObserver>();

        public States SubjectState { get; private set; }

        public Subject() { }

        public void Attach(IObserver observer)
        {
            _Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _Observers)
            {
                observer.Update(SubjectState);
            }
        }

        public States GetState()
        {
            return SubjectState;
        }

        public void SetState(States state)
        {
            SubjectState = state;
            Notify();
        }
    }
}
