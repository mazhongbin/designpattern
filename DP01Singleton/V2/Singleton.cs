namespace DP01Singleton.V2
{
    public sealed class Singleton
    {
        static Singleton instance = null;

        private static readonly object padlock = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
