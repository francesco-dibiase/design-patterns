namespace DesignPatterns.BehavioralPatterns.Mediator
{
    public interface IMediator
    {
        public void Notify(AbstractColleague sender, string @event);
    }
}
