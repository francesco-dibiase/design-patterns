namespace DesignPatterns.Creational_Patterns.Factory_Method
{
    public abstract class Document : IDocument
    {
        public virtual string? Name { get; private set; } = string.Empty;
        public Document(string name)
        {
            Name = name;
        }
        public virtual void Open()
        {
            Console.WriteLine($"Opening: {Name}");
        }

        public virtual void Close()
        {
            Console.WriteLine($"Closing: {Name}");
        }

        public virtual void Save()
        {
            Console.WriteLine($"Saving: {Name}");
        }

        public virtual void Revert()
        {
            Console.WriteLine($"Reverting: {Name}");
        }
    }
}