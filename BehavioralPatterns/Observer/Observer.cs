using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    public class Observer : IObserver
    {
        public States ObserverState { get; private set; } = States.StateA;
        public Observer() { }
        public void Update(States state)
        {
            ObserverState = state;
        }
    }
}
