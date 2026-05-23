namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
      public class PresentationManagerScrollBar : IScrollbar
      {
            public void Scroll()
            {
                  Console.WriteLine("[ -- ]\tPresentation Manager scrollbar has been scrolled.");
            }
      }
}
