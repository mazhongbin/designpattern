namespace DP01Singleton.V4
{
    public sealed class Singleton
    {
        static Singleton()
        {
            GetInstance = new Singleton();
        }

        private Singleton()
        {

        }

        public static Singleton GetInstance { get; private set; } = null;
    }
}
