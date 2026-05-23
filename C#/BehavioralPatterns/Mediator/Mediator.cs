namespace DesignPatterns.BehavioralPatterns.Mediator
{
    public class Mediator : IMediator
    {
        private List<AbstractColleague> _Colleagues = new List<AbstractColleague>();

        public IMediator AddColleague(AbstractColleague colleague)
        {
            _Colleagues.Add(colleague);
            return this;
        }

        public IMediator AddColleague(params AbstractColleague[] colleagues)
        {
            _Colleagues.AddRange(colleagues);
            return this;
        }

        public IMediator AddColleague(IEnumerable<AbstractColleague> colleagues)
        {
            _Colleagues.AddRange(colleagues);
            return this;
        }

        public void Notify(AbstractColleague sender, string @event)
        {
            if (_Colleagues.Count <= 0) 
            {
                Console.WriteLine("No colleague found");
                return;
            }

            _Colleagues.ForEach(c => { if (c != sender) c.Receive(@event); });
        }
    }
}
