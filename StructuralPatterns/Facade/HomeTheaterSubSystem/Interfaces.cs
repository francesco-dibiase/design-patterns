using DesignPatterns.Structural_Patterns.Facade.Accessories;

namespace DesignPatterns.Structural_Patterns.Facade.HomeTheaterSubSystem
{
    internal interface IDevice
    {
        public void Power();
    }
    internal interface IDiskReader : IDevice
    {
        public void ReadDVD();
        public bool IsDVDInserted();
        public void InsertDVD(IDisk disk);
        public void EjectDVD();
    }
    internal interface IMonitor : IDevice
    {
        //
    }
    internal interface ISpeaker : IDevice
    {
        //
    }
    internal interface IUSBReader : IDevice
    {
        //
    }
}
