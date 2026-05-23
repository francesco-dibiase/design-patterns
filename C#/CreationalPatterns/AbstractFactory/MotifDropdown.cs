namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
      internal class MotifDropdown : IDropdown
      {
            public MotifDropdown() { }
            public void Open()
            {
                  Console.WriteLine("[ -- ]\tMotif window has been opened.");
            }

            public void Close()
            {
                  Console.WriteLine("[ -- ]\tMotif window has been closed.");
            }
      }
}
