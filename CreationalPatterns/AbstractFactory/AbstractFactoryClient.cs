namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    public class AbstractFactoryClient
    {
        private readonly ScrollBar _scrollBar;
        private readonly Window _window;
        private readonly IWidgetFactory _WidgetFactory;
        public AbstractFactoryClient(IWidgetFactory widgetFactory)
        {
            Console.WriteLine("App has been created");
            _WidgetFactory = widgetFactory;
            _scrollBar = _WidgetFactory.CreateScrollBar();
            _window = _WidgetFactory.CreateWindow();
        }
        public void Run()
        {
            _window.Action();
            _scrollBar.Action();
        }
    }
}
