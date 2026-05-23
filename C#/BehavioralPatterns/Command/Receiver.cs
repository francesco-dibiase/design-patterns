namespace DesignPatterns.BehavioralPatterns.Command
{
    public class Receiver : IReceivable
    {
        public string ActionDescription { get; private set; }
        public Receiver(string actionDescription)
        {
            this.ActionDescription = actionDescription;
        }
        public void Action()
        {
            Console.WriteLine($"[ -- ] {nameof(Receiver)}: Executing the action: {ActionDescription}");
        }
    }
}
