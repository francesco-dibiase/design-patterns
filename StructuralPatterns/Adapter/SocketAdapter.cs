namespace DesignPatterns.Structural_Patterns.Adapter
{
    internal class SocketAdapter : IVoltage
    {
        private readonly Socket _Socket;
        public SocketAdapter(Socket socket)
        {
            _Socket = socket;
        }

        public int GetVoltage()
        {
            return _Socket.ProvideElectricity();
        }
    }
}
