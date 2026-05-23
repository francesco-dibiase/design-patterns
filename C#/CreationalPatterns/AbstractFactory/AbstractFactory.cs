namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
      public class AbstractFactory
      {
            private readonly IScrollbar ScrollBar;
            private readonly IDropdown Window;
            private readonly IWidgetFactory WidgetFactory;

            public AbstractFactory(IWidgetFactory widgetFactory)
            {
                  Console.WriteLine("[ -- ]\tFactory has been created.");
                  WidgetFactory = widgetFactory;
                  ScrollBar = WidgetFactory.CreateScrollbar();
                  Window = WidgetFactory.CreateDropdown();
            }

            public void Run()
            {
                  Window.Open();
                  ScrollBar.Scroll();
            }
      }
}
