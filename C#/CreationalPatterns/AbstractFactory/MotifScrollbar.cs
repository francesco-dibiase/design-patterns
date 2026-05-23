namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
      public class MotifScrollbar : IScrollbar
      {
            public void Scroll()
            {
                  Console.WriteLine("[ -- ]\tMotif scrollbar has been scrolled.");
            }
      }
}
