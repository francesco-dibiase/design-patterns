

using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    public class Colleague : AbstractColleague
    {
        private readonly string _Name;
        public Colleague(IMediator mediator, string name) : base(mediator: mediator) { _Name = name; }

        override public void DoOperation(string @event)
        {
            Console.WriteLine($"[ -- ] This colleague named {_Name} is doing his operations, and soon the mediator" +
                $" will notify to other colleagues.");
            _Mediator.Notify(this, @event);
        }

        override internal void Receive(string @event)
        {
            Console.WriteLine($"[ -- ] The mediator signaled the colleague named {_Name} and will update accordingly.");
        }
    }
}
