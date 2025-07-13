namespace DesignPatterns.BehavioralPatterns.Command
{
    public class Receiver : IReceivable
    {
        public void Action()
        {
            Console.WriteLine($"{nameof(Receiver)}: Executing the action");
        }
    }
}
