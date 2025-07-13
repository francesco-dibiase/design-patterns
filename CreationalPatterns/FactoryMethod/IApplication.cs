namespace DesignPatterns.Creational_Patterns.Factory_Method
{
    internal interface IApplication
    {
        public Document CreateDocument(string docName);
        public Document NewDocument(string docName);
        public Document OpenDocument(string docName);
    }
}
