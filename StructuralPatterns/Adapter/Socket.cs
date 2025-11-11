namespace DesignPatterns.Structural_Patterns.Adapter
{
    internal class Socket : ISocket
    {
        public int ProvideElectricity()
        {
            return 220;
        }
    }
}
