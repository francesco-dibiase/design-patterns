namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
      public class XMLParser : IParser
      {
            public void Parse(object obj)
            {
                  string typeName = obj == null ? "null" : obj.GetType().Name;
                  Console.WriteLine($"[ -- ]\tDeserializing a XML into an object of type {typeName}.");
            }
      }
}
