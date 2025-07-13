namespace DesignPatterns.Structural_Patterns.Adapter
{
    internal class Device
    {
        private readonly IVoltage _Voltage;

        public Device(IVoltage voltage)
        {
            _Voltage = voltage;
        }
        public void Operate()
        {
            Console.WriteLine($"Device is operating at {_Voltage.GetVoltage()} volts");
        }
    }
}
