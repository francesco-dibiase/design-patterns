namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
      public class JSONParser : IParser
      {
            public void Parse(object obj)
            {
                  string typeName = obj == null ? "null" : obj.GetType().Name;
                  Console.WriteLine($"[ -- ]\tDeserializing a JSON into an object of type {typeName}.");
            }
      }
}
