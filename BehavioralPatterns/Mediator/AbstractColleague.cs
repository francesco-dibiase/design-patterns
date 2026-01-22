namespace DesignPatterns.BehavioralPatterns.Mediator
{
    public abstract class AbstractColleague : IColleague
    {
        protected readonly IMediator _Mediator;

        public AbstractColleague(IMediator mediator)
        {
            this._Mediator = mediator;
        }

        public virtual void DoOperation(string @event)
        {
            Console.WriteLine($"[ -- ] This colleague named {this} is doing his operations, and soon the mediator" +
                $" will notify to other colleagues.");
            _Mediator.Notify(this, @event);
        }

        internal abstract void Receive(string @event);
    }
}
