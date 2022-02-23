namespace DesignPatterns.CreationalPatterns.SingletonPattern
{
    public class SingletonClass
    {
        public int AnInteger { get;private set; }

        private static SingletonClass instance;

        private static object intLock = new object();

        private static object instanceLock = new object();

        public static SingletonClass GetInstance()
        {
            if (instance is null)
            {
                lock (instanceLock)
                {
                    if (instance is null)
                        instance = new SingletonClass();
                }
            }
            return instance;
        }
        public void IncreaseInteger()
        {
            lock(intLock)
            {
                AnInteger++;
            }
        }
        private SingletonClass()
        {
        }
    }
}