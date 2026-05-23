namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
      public abstract class ParserFactory : IParserFactory
      {
            public abstract IParser CreateParser();

            public void ProcessFile(string content)
            {
                  IParser parser = CreateParser();
                  parser.Parse(content);
            }
      }

      public class JSONParserFactory : ParserFactory
      {
            public override IParser CreateParser() => new JSONParser();
      }

      public class XMLParserFactory : ParserFactory
      {
            public override IParser CreateParser() => new XMLParser();
      }
}
