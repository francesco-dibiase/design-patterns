using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    public interface IObserver
    {
        void Update(States state);
    }
}
