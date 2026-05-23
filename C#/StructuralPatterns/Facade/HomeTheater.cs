using DesignPatterns.Structural_Patterns.Facade.HomeTheaterSubSystem;
using System.Runtime.CompilerServices;

namespace DesignPatterns.Structural_Patterns.Facade
{
    internal class HomeTheater : IHomeTheater<HomeTheater>
    {
        private static HomeTheater? _HomeTheaterInstance;
        private static readonly object _SingleThreadSingletonObj = new object();

        public IDiskReader DiskReader { get; init; }
        public IMonitor Monitor { get; init; }
        public ISpeaker Speaker { get; init; }
        public IUSBReader USBReader { get; init; }

        private HomeTheater(IDiskReader diskReader,
                            IMonitor monitor,
                            ISpeaker speaker,
                            IUSBReader usbReader) 
        {
            this.DiskReader = diskReader;
            this.Monitor = monitor;
            this.Speaker = speaker;
            this.USBReader = usbReader;
        }
        static public HomeTheater TurnOn()
        {
            _HomeTheaterInstance ??= Init();
            _HomeTheaterInstance.DiskReader?.Power();
            _HomeTheaterInstance.Monitor?.Power();
            _HomeTheaterInstance.Speaker?.Power();
            _HomeTheaterInstance.USBReader?.Power();

            return _HomeTheaterInstance;
        }
        static public HomeTheater Init(IDiskReader? diskReader = null, 
                                        IMonitor? monitor = null, 
                                        ISpeaker? speaker = null,
                                        IUSBReader? usbReader = null)
        {
            lock (_SingleThreadSingletonObj) 
            {
                if (null == _HomeTheaterInstance)
                {
                    diskReader = diskReader == null ? new DVDReader() : diskReader;
                    monitor = monitor == null ? new HomeTheaterSubSystem.Monitor() : monitor;
                    speaker = speaker == null ? new Speaker() : speaker;
                    usbReader = usbReader == null ? new USBReader() : usbReader;
                    _HomeTheaterInstance = new HomeTheater(diskReader, monitor, speaker, usbReader);
                }
                return _HomeTheaterInstance;
            }
        }
    }
}
