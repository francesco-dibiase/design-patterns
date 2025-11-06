using DesignPatterns.BehavioralPatterns.ChainOfResponsibility;
using DesignPatterns.BehavioralPatterns.Command;
using AppStudio.PatternsApp.Utility;
using DesignPatterns.BehavioralPatterns.Iterator;

public static class Client
{
    public static void ChainOfResponsibilityImplementation()
    {
        IHandler handler = new Handler(IssueType.Issue01)
        .SetNext(new Handler(IssueType.Issue02)
              .SetNext(new Handler(IssueType.Issue03)
                    .SetNext(new Handler(IssueType.Issue04))));
        handler.HandleRequest(IssueType.Issue02);
    }

    public static void CommandImplementation()
    {
        Receiver receiver1 = new Receiver("Right Click");
        Receiver receiver2 = new Receiver("Print Document");
        Receiver receiver3 = new Receiver("Save Document");

        Command<Receiver> command = new Command<Receiver>(receiver1);
        Command<Receiver> command2 = new Command<Receiver>(receiver2);
        Command<Receiver> command3 = new Command<Receiver>(receiver3);

        new Invoker(command, command2, command3).Invoke();
    }

    public static void IteratorImplementation()
    {
        List<string> elements = new() { "primo", "secondo", "terzo", "quarto", "quinto", "sesto" };
        Iterator<string> iterator = new Iterator<string>(elements);
        while (!iterator.IsDone())
        {
            iterator.CurrentItem();
            iterator.Next();
        }
    }
}
