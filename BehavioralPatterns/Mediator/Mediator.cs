using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    public class Mediator : IMediator
    {
        private List<IColleague> _Colleagues = new List<IColleague>();

        public IMediator AddColleague(IColleague c)
        {
            _Colleagues.Add(c);
            return this;
        }

        public IMediator AddColleague(params IColleague[] c)
        {
            _Colleagues.AddRange(c);
            return this;
        }

        public IMediator AddColleague(IEnumerable<IColleague> c)
        {
            _Colleagues.AddRange(c);
            return this;
        }

        public void Notify(IColleague sender)
        {
            IColleague? c = _Colleagues.FirstOrDefault((c) => c.operationType == sender.operationType);

            switch (c?.operationType)
            {
                case ColleagueType.Colleague01:
                    _Colleagues.FirstOrDefault((c) => c.operationType == ColleagueType.Colleague02)?.DoOperation();
                    return;
                case ColleagueType.Colleague02:
                    _Colleagues.FirstOrDefault((c) => c.operationType == ColleagueType.Colleague03)?.DoOperation();
                    return;
                case ColleagueType.Colleague03:
                    _Colleagues.FirstOrDefault((c) => c.operationType == ColleagueType.Colleague04)?.DoOperation();
                    return;
                case ColleagueType.Colleague04:
                    Console.WriteLine("Last Type of Colleague has done it's operation, returning...");
                    return;
            }
            Console.WriteLine("No colleague found");
            return;
        }
    }
}
