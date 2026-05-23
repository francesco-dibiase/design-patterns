using DesignPatterns.BehavioralPatterns.ChainOfResponsibility;
using DesignPatterns.BehavioralPatterns.Command;
using DesignPatterns.Utility;
using DesignPatterns.BehavioralPatterns.Iterator;
using DesignPatterns.BehavioralPatterns.Mediator;
using DesignPatterns.BehavioralPatterns.Memento;

public static class Client
{
      public static void ChainOfResponsibilityImplementation()
      {
            Console.WriteLine("""
            ------ [ CHAIN OF RESPONSIBILITY ] ------
            Intento: Creare una catena di oggetti che possono gestire
            un compito, disaccoppiando la richiesta (request | issue)
            da chi la gestisce (handler).
            La richiesta viene passata tramite una catena di handler
            e ogni oggetto ha le proprietà per decidere se può gestire
            la richiesta o passarla all'handler successivo.
            -----------------------------------------
            """);
            IHandler handler = new Handler(IssueType.Issue01)
            .SetNext(new Handler(IssueType.Issue02)
                  .SetNext(new Handler(IssueType.Issue03)
                        .SetNext(new Handler(IssueType.Issue04))));
            handler.HandleRequest(IssueType.Issue02);
      }

      public static void CommandImplementation()
      {
            Console.WriteLine("""
            -------------- [ COMMAND ] --------------
            Intento: incapsulare una richiesta all’interno di un oggetto
            comando, delegandone l’esecuzione a un ricevitore e disaccoppiando
            l’invocatore dall’oggetto che esegue l’azione.
            -----------------------------------------
            """);
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
            Console.WriteLine("""
            -------------- [ ITERATOR ] --------------
            Intento: Fornire l'accesso ad oggetti aggregati
            sequenzialmente, senza esporre la sua rappresentazione.
            ------------------------------------------
            """);
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
            Console.WriteLine("""
            -------------- [ MEDIATOR ] --------------
            Intento: Fornire un oggetto che incapsula alcune modalità di interazione
            tra un insieme di oggetti, promuovendo un legame tra essi non vincolante ed
            evitando riferimenti espliciti reciproci.
            ------------------------------------------
            """);
            Mediator mediator = new Mediator();
            AbstractColleague colleague01 = new Colleague(mediator, $"{nameof(colleague01)}");
            AbstractColleague colleague02 = new Colleague(mediator, $"{nameof(colleague02)}");
            AbstractColleague colleague03 = new Colleague(mediator, $"{nameof(colleague03)}");
            AbstractColleague colleague04 = new Colleague(mediator, $"{nameof(colleague04)}");

            mediator.AddColleague(colleague01, colleague02, colleague03, colleague04);

            colleague01.DoOperation("clean the room");
      }

      public static void MementoImplementation()
      {
            Console.WriteLine("""
                        -------------- [ MEMENTO ] --------------
                        Intento: Cattura ed esternalizza lo stato interno di un oggetto, ma senza
                        violare il principio di incapsulamento, cosi che l'oggetto possa ripristinare
                        il suo stato precedentemente salvato.
                        ------------------------------------------
                        """);
            Originator originator = new Originator("Arial", "bold", null);
            CareTaker<Originator> careTaker = new CareTaker<Originator>(originator);
            Console.WriteLine($"written new line with value:\n {originator.SetText("first text\n")}");
            careTaker.SetMemento();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"written new line with value: {originator.SetText("second text\n")}");
            careTaker.SetMemento();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"written new line with value: {originator.SetText("third text\n")}");
            careTaker.SetMemento();
            Console.WriteLine("------------------------------------------");
            careTaker.Undo();
            Console.Write(careTaker.Originator.Text);
            Console.WriteLine("------------------------------------------");
            careTaker.Undo();
            Console.Write(careTaker.Originator.Text);
            Console.WriteLine("------------------------------------------");
            careTaker.Undo();
            Console.Write(careTaker.Originator.Text);
            Console.WriteLine("------------------------------------------");
      }

      public static void ObserverImplementation()
      {
            Console.WriteLine("""
                        -------------- [ OBSERVER ] --------------
                        Intento: Stabilisce una relazione uno a molti tra oggetti, così che quando un oggetto
                        cambia stato, tutti gli altri oggetti vengano notificati di tale cambiamento e
                        reagiscano di conseguenza.
                        ------------------------------------------
                        """);
      }
}
