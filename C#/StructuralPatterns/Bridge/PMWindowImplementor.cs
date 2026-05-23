namespace DesignPatterns.Structural_Patterns.Bridge
{
    public class PMWindowImplementor : IWindowImplementor
    {
        public void DevDrawLine()
        {
            PMDrawLine();
        }

        public void DevDrawText()
        {
            PMDrawText();
        }

        public void PMDrawLine() { }

        public void PMDrawText() { }
    }
}
