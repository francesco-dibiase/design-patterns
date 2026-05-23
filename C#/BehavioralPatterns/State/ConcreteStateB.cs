using DesignPatterns.Utility;

namespace DesignPatterns.BehavioralPatterns.State
{
    internal class ConcreteStateB : State
    {
        public const States PatternState = States.StateB;
        public override void Handle(Context context)
        {
            context.isResolving = true;
            Console.WriteLine("Handling State B...");
            Task.Delay(TimeSpan.FromSeconds(3)).Wait();
            StateC state = new StateC();
            context.SetState(state);
            Console.WriteLine("State B handled, passing to state C");
            state.Handle(context);
        }
        public States GetState()
        {
            return PatternState;
        }
    }
}
