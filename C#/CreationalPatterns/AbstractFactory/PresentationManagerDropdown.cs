namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
      public class PresentationManagerDropdown : IDropdown
      {
            public void Open()
            {
                  Console.WriteLine("[ -- ]\tPresentation Manager dropdown has been opened.");
            }

            public void Close()
            {
                  Console.WriteLine("[ -- ]\tPresentational manager dropdown has been closed.");
            }
      }
}
