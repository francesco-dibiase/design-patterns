namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    public class PresentationManagerScrollBar : ScrollBar
    {
        public PresentationManagerScrollBar() { }
        public sealed override void Action()
        {
            Console.WriteLine("I have scrolled a Presentation Manager ScrollBar");
        }
    }
}