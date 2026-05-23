namespace DesignPatterns.Structural_Patterns.Decorator
{
    internal abstract class AbstractDecorator : IVisualComponent
    {
        IVisualComponent VisualComponent { get; set; }
        public AbstractDecorator(IVisualComponent visualComponent)
        {
            VisualComponent = visualComponent;
        }

        public void Draw()
        {
            VisualComponent.Draw();
        }
    }
}
