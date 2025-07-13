using AppStudio.PatternsApp.Utility;

namespace DesignPatterns.BehavioralPatterns.State
{
    internal class StateC : State
    {
        public const States PatternState = States.StateC;

        public override void Handle(Context context)
        {
            Console.WriteLine("Handling State C...");
            Task.Delay(TimeSpan.FromSeconds(3)).Wait();
            ConcreteStateA state = new ConcreteStateA();
            context.SetState(state);
            context.isResolving = false;
            Console.WriteLine("Returning to State A");
        }
        public States GetState()
        {
            return PatternState;
        }
    }
}
