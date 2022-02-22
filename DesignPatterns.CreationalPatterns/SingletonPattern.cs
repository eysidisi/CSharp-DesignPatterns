namespace DesignPatterns.CreationalPatterns
{
    public class SingletonPattern
    {
        public int anInteger;

        private static SingletonPattern instance;

        public static SingletonPattern GetInstance()
        {
            if (instance == null)
                instance = new SingletonPattern();
            return instance;
        }

        private SingletonPattern()
        {
            anInteger = 0;
        }
    }
}