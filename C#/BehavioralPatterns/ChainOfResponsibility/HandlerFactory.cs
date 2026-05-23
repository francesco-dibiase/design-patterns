using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
      public class HandlerFactory<T>(IHandlerBuilder<IHandler> builder) : IHandlerFactory where T : IHandler
      {
            private readonly IHandlerBuilder<IHandler> Builder = builder;

            public void HandleRequest(RequestType request)
            {
                  Console.WriteLine($"[ -- ]\tTrying to fulfill the request of type {request} through the chain...");
                  foreach (var handler in Builder.ReadHandlers)
                  {
                        if (handler.TryHandleRequest(request)) return;
                  }
                  Console.WriteLine($"[ -- ] No registered handler has been cabable of handling the request.");
            }

            public Task HandleRequestAsync(RequestType issue, CancellationToken cancellationToken)
            {
                  throw new NotImplementedException();
            }
      }
}
