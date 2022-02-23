namespace DesignPatterns.CreationalPatterns.SingletonPattern
{
    public class SingletonClass
    {
        public int anInteger;

        private static SingletonClass instance;

        public static SingletonClass GetInstance()
        {
            if (instance == null)
                instance = new SingletonClass();
            return instance;
        }

        private SingletonClass()
        {
            anInteger = 0;
        }
    }
}