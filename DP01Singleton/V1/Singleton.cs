namespace DP01Singleton.V1
{
    public sealed class Singleton
    {
        static Singleton instance = null;
        private Singleton()
        {

        }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
    }
}
