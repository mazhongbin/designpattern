namespace DP01Singleton.V3
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
                if (instance == null)
                {

                    lock (padlock)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
    }
}
