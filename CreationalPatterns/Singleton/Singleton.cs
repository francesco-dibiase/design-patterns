namespace DesignPatterns.Creational_Patterns.Singleton
{
    public class LazySingleton
    {
        private static LazySingleton? _Instance;

        private static readonly object _lock = new object();
        private LazySingleton() { }

        public static LazySingleton Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (_lock)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new LazySingleton();
                        }
                    }
                }
                return _Instance;
            }
        }
    }

    public class EagerSingleton
    {
        private static readonly EagerSingleton _Instance = new EagerSingleton();
        private EagerSingleton() { }

        public static EagerSingleton Instance
        {
            get
            {
                return _Instance;
            }
        }
    }

    public class ModernLazySingleton
    {
        private static readonly bool _IsThreadSafe = false;
        private static readonly Lazy<ModernLazySingleton> _Instance = new Lazy<ModernLazySingleton>(() => new ModernLazySingleton(), _IsThreadSafe);

        private ModernLazySingleton() { }

        public static ModernLazySingleton Instance = _Instance.Value;
    }
}
