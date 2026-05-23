namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
      public interface IWidgetFactory
      {
            public IDropdown CreateDropdown();
            public IScrollbar CreateScrollbar();
      }
}
