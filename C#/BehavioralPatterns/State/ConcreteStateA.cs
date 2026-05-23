using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.State
{
    internal class ConcreteStateA : State
    {
        public const States PatternState = States.StateA;
        public override void Handle(Context context)
        {
            context.isResolving = true;
            Console.WriteLine("Handling State A...");
            Task.Delay(TimeSpan.FromSeconds(3)).Wait();
            Console.WriteLine("State A handled, passing to state B");
            ConcreteStateB state = new ConcreteStateB();
            context.SetState(state);
            state.Handle(context);
        }
        public States GetState()
        {
            return PatternState;
        }
    }
}
