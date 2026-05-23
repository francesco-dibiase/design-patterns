namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    public abstract class ScrollBar : IComponent
    {
        public virtual void Action()
        {
            Console.WriteLine("I scrolled a Scrollbar");
        }
    }
}
