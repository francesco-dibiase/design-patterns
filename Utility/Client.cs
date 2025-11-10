using DesignPatterns.BehavioralPatterns.ChainOfResponsibility;
using DesignPatterns.BehavioralPatterns.Command;
using DesignPatterns.Utility;
using DesignPatterns.BehavioralPatterns.Iterator;
using DesignPatterns.BehavioralPatterns.Mediator;

public static class Client
{
    public static void ChainOfResponsibilityImplementation()
    {
        Console.WriteLine("------ [ CHAIN OF RESPONSIBILITY ] ------");
        IHandler handler = new Handler(IssueType.Issue01)
        .SetNext(new Handler(IssueType.Issue02)
              .SetNext(new Handler(IssueType.Issue03)
                    .SetNext(new Handler(IssueType.Issue04))));
        handler.HandleRequest(IssueType.Issue02);
    }

    public static void CommandImplementation()
    {
        Console.WriteLine("------ [ COMMAND ] ------");
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
        Console.WriteLine("------ [ ITERATOR ] ------");
        List<string> elements = new() { "first", "second", "third", "fourth", "fifth", "sixth" };
        Iterator<string> iterator = new Iterator<string>(elements);
        while (!iterator.IsDone())
        {
            iterator.CurrentItem();
            iterator.Next();
        }
    }

    public static void MediatorImplentation()
    {
        Console.WriteLine("------ [ MEDIATOR ] ------");
        Mediator mediator = new Mediator();
        IColleague colleague01 = new Colleague(mediator, ColleagueType.Colleague01);
        IColleague colleague02 = new Colleague(mediator, ColleagueType.Colleague02);
        IColleague colleague03 = new Colleague(mediator, ColleagueType.Colleague03);
        IColleague colleague04 = new Colleague(mediator, ColleagueType.Colleague04);

        mediator.AddColleague(colleague01, colleague02, colleague03, colleague04);

        colleague01.DoOperation();

    }
}
