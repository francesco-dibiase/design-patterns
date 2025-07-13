namespace DesignPatterns.Structural_Patterns.Composite
{
    public interface IFileSystem
    {
        public void Open();
        public void Rename(string newName);
        public void Delete();
    }
}