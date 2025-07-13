using AppStudio.PatternsApp.Utility;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public interface IHandler
    {
        public void HandleRequest(IssueType issue);
        public IHandler SetNext(IHandler handler);
    }
}
