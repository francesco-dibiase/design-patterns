namespace DesignPatterns.BehavioralPatterns.Command
{
    class Invoker
    {
        private List<ICommand> Commands;
        public Invoker(params ICommand[] commands)
        {
            Commands = [.. commands];
        }
        public void Invoke()
        {
            foreach (var item in Commands)
            {
                item.Execute();
            }
        }
    }
}
