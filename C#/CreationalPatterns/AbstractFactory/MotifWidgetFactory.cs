namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    internal class MotifWidgetFactory : IWidgetFactory
    {
        public MotifWidgetFactory() { }
        public Window CreateWindow()
        {
            return new MotifWindow();
        }
        public ScrollBar CreateScrollBar()
        {
            return new MotifScrollBar();
        }
    }
}
