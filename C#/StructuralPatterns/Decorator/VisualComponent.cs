namespace DesignPatterns.Structural_Patterns.Decorator
{
    internal abstract class VisualComponent : IVisualComponent
    {
        protected string _Text { get; set; }
        public VisualComponent(string text)
        {
            _Text = text;
        }
        public void Draw()
        {
            Console.WriteLine(_Text);
        }
    }
}
