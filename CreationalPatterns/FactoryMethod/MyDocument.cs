namespace DesignPatterns.Creational_Patterns.Factory_Method
{
    internal class MyDocument : Document
    {
        public MyDocument(string name) : base(name) { }

        public sealed override void Open()
        {
            Console.WriteLine($"Opening: {Name}, which is a MyDocument");
        }
    }
}
