using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    public interface IColleague
    {
        public ColleagueType operationType { get; }
        public void DoOperation();
    }
}
