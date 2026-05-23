using System.ComponentModel;
using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
      public interface IHandler
      {
            public bool HandleRequest(IssueType issue);
      }

      public interface IHandlerFactory
      {
            public IHandler SetNext(IHandler handler);
      }
}
