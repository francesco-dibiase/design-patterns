namespace DesignPatterns.Structural_Patterns.Bridge
{
    internal abstract class Window : IWindow
    {
        private IWindowImplementor _WindowImplementor;
        public Window(IWindowImplementor windowImplementor)
        {
            _WindowImplementor = windowImplementor;
        }
        public void DrawRect()
        {
            Console.WriteLine("Drawing a Rectangle...");
            _WindowImplementor.DevDrawLine();
            _WindowImplementor.DevDrawLine();
            _WindowImplementor.DevDrawLine();
            _WindowImplementor.DevDrawLine();

            _WindowImplementor.DevDrawText();
        }
        public void DrawText()
        {
            Console.WriteLine("Drawing Text...");
        }
    }
}
