namespace DesignPatterns.Structural_Patterns.Bridge
{
    internal class XWindowImplementor : IWindowImplementor
    {
        public void DevDrawLine()
        {
            XDrawLine();
        }

        public void DevDrawText()
        {
            XDrawText();
        }

        public XWindowImplementor() { }

        public void XDrawLine() { }
        public void XDrawText() { }
    }
}
