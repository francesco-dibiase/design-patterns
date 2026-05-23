namespace DesignPatterns.BehavioralPatterns.Command
{
      public class Command<T>(T receiver) : ICommand where T : IReceivable
      {
            private readonly T Receiver = receiver;

            public void Execute()
            {
                  Receiver.Action();
            }
      }
}
