using DesignPatterns.Structural_Patterns.Proxy;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            subject.Request();
        }
    }
}
