using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public interface IHandler
    {
        public bool HandleRequest(IssueType issue);
        public IHandler SetNext(IHandler handler);
        public string GetTypeOfHandler();
    }
}
