namespace DesignPatterns.BehavioralPatterns.Command
{
    public class Command<T> : ICommand where T : IReceivable
    {
        private T _Receiver;

        public Command(T receiver)
        {
            _Receiver = receiver;
        }

        public void Execute()
        {
            _Receiver.Action();
        }
    }
}
