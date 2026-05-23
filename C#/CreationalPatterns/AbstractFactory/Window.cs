namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    public abstract class Window : IComponent
    {
        public virtual void Action()
        {
            Console.WriteLine("I opened a Window");
        }
    }
}
