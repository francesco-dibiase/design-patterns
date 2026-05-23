using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
      public interface IHandler
      {
            public bool TryHandleRequest(RequestType issue);
      }

      public interface IHandlerBuilder<T> where T : IHandler
      {
            public List<T> ReadHandlers { get; }
            public IHandlerBuilder<T> AddHandler(T handler);
      }

      public interface IHandlerFactory
      {
            public void HandleRequest(RequestType issue);
            public Task HandleRequestAsync(RequestType issue, CancellationToken cancellationToken);
      }
}
