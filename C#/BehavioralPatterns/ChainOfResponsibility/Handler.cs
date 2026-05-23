using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
      public class Handler(RequestType requestType) : IHandler
      {
            private readonly RequestType RequestType = requestType;

            public bool TryHandleRequest(RequestType request)
            {
                  if (request == RequestType)
                  {
                        Console.WriteLine($"[ -- ]\tRequest fulfilled by handler that can handle the request of type {RequestType}.");
                        return true;
                  }
                  else
                  {
                        Console.WriteLine($"[ -- ]\tThis handler can fulfill requests of type {RequestType}.\n" +
                              "\tPassing the responsibility to handle the request to the handler" +
                              $" that can handle the request of type {request}");
                  }

                  return false;
            }
      }
}
