namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
      internal class MotifWidgetFactory : IWidgetFactory
      {
            public MotifWidgetFactory()
            {

                  Console.WriteLine("[ -- ]\tCreated a Motif Widget Factory.");
            }

            public IDropdown CreateDropdown()
            {
                  return new MotifDropdown();
            }
            public IScrollbar CreateScrollbar()
            {
                  return new MotifScrollbar();
            }
      }
}
