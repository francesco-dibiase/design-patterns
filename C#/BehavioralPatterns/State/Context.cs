namespace DesignPatterns.BehavioralPatterns.State
{
    public class Context
    {
        public Istate State { get; private set; }
        public bool isResolving { get; internal set; } = false;

        public Context()
        {
            this.State = new ConcreteStateA();
        }

        internal void SetState(Istate state)
        {
            this.State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }
}
