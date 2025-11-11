

using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    public class Colleague : IColleague
    {
        private IMediator _Mediator;
        public ColleagueType operationType { get; }

        public Colleague(IMediator mediator, ColleagueType operationType)
        {
            this._Mediator = mediator;
            this.operationType = operationType;
        }

        public void DoOperation()
        {
            Console.WriteLine($"[ -- ] Concrete Mediator will soon notify another colleague using this sender," +
                  $"while is doing his operation of type: {operationType.ToString()}");
            _Mediator.Notify(this);
        }
    }
}
