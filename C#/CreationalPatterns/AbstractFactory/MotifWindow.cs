namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    internal class MotifWindow : Window
    {
        public MotifWindow() { }
        public sealed override void Action()
        {
            Console.WriteLine("Motif Window has been opened");
        }
    }
}
