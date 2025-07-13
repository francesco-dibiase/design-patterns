using AppStudio.PatternsApp.Utility;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public class Handler : IHandler
    {
        private IHandler? _Successor;
        private IssueType _typeOfIssueHandler;
        public Handler(IssueType typeOfIssueHandler) 
        {
            _typeOfIssueHandler = typeOfIssueHandler;
        }

        public void HandleRequest(IssueType issue)
        {
            Console.WriteLine($"Handler processing request...");
            if (issue == _typeOfIssueHandler)
            {
                Console.WriteLine($"request handled by the last handler of the chain, that handles issues of type: {issue}");
                return;
            }
            if (_Successor == null)
            {
                Console.WriteLine($"no handler in the chain can handle the request of type: {issue}");
                return;
            }
            _Successor.HandleRequest(issue);
        }

        public IHandler SetNext(IHandler nextHandler)
        {
            Console.WriteLine($"Passing the responsibility to handle the request to: {nameof(nextHandler)}");
            _Successor = nextHandler;
            return nextHandler;
        }
    }
}