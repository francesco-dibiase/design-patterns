namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
      public class PresentationManagerWidgetFactory : IWidgetFactory
      {
            public PresentationManagerWidgetFactory()
            {
                  Console.WriteLine("[ -- ]\tCreated a PresentationManagerFactory.");
            }
            public IDropdown CreateDropdown()
            {
                  return new PresentationManagerDropdown();
            }
            public IScrollbar CreateScrollbar()
            {
                  return new PresentationManagerScrollBar();
            }
      }
}
