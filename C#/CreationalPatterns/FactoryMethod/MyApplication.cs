namespace DesignPatterns.Creational_Patterns.Factory_Method
{
    public class MyApplication : Application
    {
        public MyApplication() : base() { }
        public override Document CreateDocument(string name)
        {
            return new MyDocument(name);
        }
    }
}