namespace DesignPatterns.BehavioralPatterns.State
{
    public abstract class State : Istate
    {
        public abstract void Handle(Context context);
    }
}