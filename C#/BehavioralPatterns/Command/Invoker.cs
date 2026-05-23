namespace DesignPatterns.BehavioralPatterns.Command
{
      class Invoker(params ICommand[] commands)
      {
            private List<ICommand> Commands = [.. commands];

            public void Invoke()
            {
                  foreach (var item in Commands)
                  {
                        item.Execute();
                  }
            }
      }
}
