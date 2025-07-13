namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    public class PresentationManagerWindow : Window
    {
        public PresentationManagerWindow() { }
        public sealed override void Action()
        {
            Console.WriteLine("Presentation Manager window has been opened");
        }
    }
}