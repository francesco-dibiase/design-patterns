namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
      public class HandlerBuilder<T> : IHandlerBuilder<T> where T : IHandler
      {
            public List<T> Handlers { get; private set; }

            public List<T> ReadHandlers => Handlers;

            public HandlerBuilder()
            {
                  Handlers = [];
            }

            public IHandlerBuilder<T> AddHandler(T handler)
            {
                  Handlers.Add(handler);
                  return this;
            }
      }
}
