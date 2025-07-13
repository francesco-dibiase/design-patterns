namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    public class MotifScrollBar : ScrollBar
    {
        public MotifScrollBar() { }
        public sealed override void Action()
        {
            Console.WriteLine("I have scrolled a motif scrollbar");
        }
    }
}
