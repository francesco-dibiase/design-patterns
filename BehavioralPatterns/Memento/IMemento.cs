namespace DesignPatterns.BehavioralPatterns.Memento
{
    public interface IMemento<T>
    {
        T GetState();
    }
}