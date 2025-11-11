using DesignPatterns.Structural_Patterns.Facade.Accessories;

namespace DesignPatterns.Structural_Patterns.Facade.HomeTheaterSubSystem
{
    class DVDReader : IDiskReader
    {
        private bool _State { get; set; } = false;
        protected IDisk? Disk { get; set; } = null;

        public void Power()
        {
            _State = !_State;
            if (_State) { Console.WriteLine($"{this.GetType().Name} turned on"); }
            else { Console.WriteLine($"{this.GetType().Name} turned off"); }
        }

        public bool IsDVDInserted()
        {
            if (Disk == null)
            {
                Console.WriteLine("Disk is not inserted.");
                return false;
            }
            if (!Disk.GetType().Equals(typeof(DVD)))
            {
                Console.WriteLine("Disk is not a DVD");
                return false;
            }
            return true;
        }

        public void ReadDVD()
        {
            if (this.IsDVDInserted())
            {
                Console.WriteLine($"Reading the dvd \"{Disk?.Name}\"");
            }
        }

        public void InsertDVD(IDisk disk)
        {
            this.Disk = disk;
        }

        public void EjectDVD()
        {
            this.Disk = null;
        }
    }

    class Monitor : IMonitor
    {
        private bool _State { get; set; } = false;
        public Monitor() { }

        public void Power()
        {
            _State = !_State;
            if (_State) { Console.WriteLine($"{this.GetType().Name} turned on"); }
            else { Console.WriteLine($"{this.GetType().Name} turned off"); }
        }
    }

    class Speaker : ISpeaker
    {
        private bool _State { get; set; } = false;
        public Speaker() { }

        public void Power()
        {
            _State = !_State;
            if (_State) { Console.WriteLine($"{this.GetType().Name} turned on"); }
            else { Console.WriteLine($"{this.GetType().Name} turned off"); }
        }
    }

    class USBReader : IUSBReader
    {
        private bool _State { get; set; } = false;
        public USBReader() { }

        public void Power()
        {
            _State = !_State;
            if (_State) { Console.WriteLine($"{this.GetType().Name} turned on"); }
            else { Console.WriteLine($"{this.GetType().Name} turned off"); }
        }
    }
}
