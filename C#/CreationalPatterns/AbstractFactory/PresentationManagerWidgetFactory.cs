namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    public class PresentationManagerWidgetFactory : IWidgetFactory
    {
        public PresentationManagerWidgetFactory() { }
        public Window CreateWindow()
        {
            return new PresentationManagerWindow();
        }
        public ScrollBar CreateScrollBar()
        {
            return new PresentationManagerScrollBar();
        }
    }
}