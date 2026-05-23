namespace DesignPatterns.Structural_Patterns.Proxy
{
    public class Subject
    {
        private ConcreteProxy proxy { get; set; }
        public Subject()
        {
            proxy = new ConcreteProxy();
        }
        public void Request()
        {
            Console.WriteLine("Forwarding the requerst to the real subject by the proxy...");
            Thread.Sleep(2000);
            proxy.Request();
        }
    }
}