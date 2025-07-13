namespace DesignPatterns.Structural_Patterns.Proxy
{
    internal class ConcreteProxy
    {
        private RealSubject realSubject;
        internal ConcreteProxy()
        {
            realSubject = new RealSubject();
        }

        internal void Request()
        {
            Console.WriteLine("The proxy is forwarding the request to the real subject...");
            Thread.Sleep(2000);
            realSubject.Request();
        }
    }
}