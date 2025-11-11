namespace DesignPatterns.Structural_Patterns.Composite
{
    public class Folder : IFileSystem
    {
        private string Name { get; set; }
        public List<IFileSystem>? Content { get; set; } = new List<IFileSystem>();

        public Folder(string name)
        {
            Name = name;
        }
        public void Open()
        {
            Console.WriteLine($"Ho aperto la cartella chiamata {this.Name}");
            Content?.ForEach((c) =>
            {
                c.Open();
            });
        }

        public void Rename(string newName)
        {
            this.Name = newName;
        }

        public void Delete()
        {
            Content = null;
            Console.WriteLine($"Cartella nominata:{Name} è stata eliminata");
        }
    }
}