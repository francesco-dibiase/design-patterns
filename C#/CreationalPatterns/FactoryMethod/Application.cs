namespace DesignPatterns.Creational_Patterns.Factory_Method
{
    public abstract class Application : IApplication
    {
        private List<Document> _documents;
        public Application()
        {
            _documents = new List<Document>();
        }

        public abstract Document CreateDocument(string name);

        public Document NewDocument(string name)
        {
            Document doc = CreateDocument(name);
            _documents.Add(doc);
            doc.Open();
            return doc;
        }

        public Document OpenDocument(string docName)
        {
            Document? doc = _documents.Find(d => d.Name?.Equals(docName) ?? false);
            if (doc == null)
            {
                throw new FileNotFoundException("Document not found", docName);
            }
            doc.Open();
            return doc;
        }
    }
}
