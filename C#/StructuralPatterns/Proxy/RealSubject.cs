namespace DesignPatterns.Structural_Patterns.Proxy
{
    internal class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("Executing the request from the Real Subject");
        }
    }
}