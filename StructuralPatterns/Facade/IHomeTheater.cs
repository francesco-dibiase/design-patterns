using DesignPatterns.Structural_Patterns.Facade.HomeTheaterSubSystem;

namespace DesignPatterns.Structural_Patterns.Facade
{
    internal interface IHomeTheater<T> where T : IHomeTheater<T>
    {
        static abstract public T Init(IDiskReader diskReader,
                                      IMonitor Monitor,
                                      ISpeaker speaker,
                                      IUSBReader usbReader);
        static abstract public T TurnOn();
    }
}
