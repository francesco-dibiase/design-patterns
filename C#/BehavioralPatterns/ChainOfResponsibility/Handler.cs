using System.ComponentModel;
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

            public bool HandleRequest(IssueType ofType)
            {
                  Console.WriteLine($"[ -- ] Handler that can process issues of type: {_typeOfIssueHandler}" +
                                    $" processing request of type: {ofType}...");
                  if (ofType == _typeOfIssueHandler)
                  {
                        Console.WriteLine($"[ -- ] Request handled by the handler of the chain" +
                                          $"that handles issues of type: {ofType}");
                        return true;
                  }
                  if (_Successor == null)
                  {
                        Console.WriteLine($"[ -- ] No handler in the chain can handle the request of type: {ofType}");
                        return false;
                  }
                  Console.WriteLine($"[ -- ] Passing the responsibility to handle the request to the handler" +
                        $" that can handle issue of type {typeof(Handler)}");
                  _Successor.HandleRequest(ofType);
                  return false;
            }
      }
}
