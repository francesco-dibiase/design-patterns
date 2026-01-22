using DesignPatterns.Utility;

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

        public bool HandleRequest(IssueType issue)
        {
            Console.WriteLine($"[ -- ] Handler that can process issues of type: {_typeOfIssueHandler}" +
                              $" processing request of type: {issue}...");
            if (issue == _typeOfIssueHandler)
            {
                Console.WriteLine($"[ -- ] Request handled by the handler of the chain" +
                                  $"that handles issues of type: {issue}");
                return true;
            }
            if (_Successor == null)
            {
                Console.WriteLine($"[ -- ] No handler in the chain can handle the request of type: {issue}");
                return false;
            }
            Console.WriteLine($"[ -- ] Passing the responsibility to handle the request to the handler" +
                              $" that can handle issue of type {_Successor.GetTypeOfHandler()}");
            _Successor.HandleRequest(issue);
            return false;
        }

        public IHandler SetNext(IHandler nextHandler)
        {
            _Successor = nextHandler;
            return this;
        }

        public string GetTypeOfHandler()
        {
            return this._typeOfIssueHandler.ToString();
        }
    }
}
