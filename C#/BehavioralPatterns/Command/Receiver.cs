namespace DesignPatterns.BehavioralPatterns.Command
{
      public class Receiver(string actionDescription) : IReceivable
      {
            private readonly string ActionDescription = actionDescription;

            public void Action()
            {
                  Console.WriteLine($"[ -- ]\tThe receiver is Executing the action {ActionDescription} after being incapsulated inside the Command class.");
            }
      }
}
