namespace DesignPatterns.Creational_Patterns.Factory_Method
{
    public interface IDocument
    {
        public void Open();
        public void Close();
        public void Save();
        public void Revert();
    }
}
