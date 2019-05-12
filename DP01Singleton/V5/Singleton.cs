namespace DP01Singleton.V5
{
    /// <summary>
    /// 调用静态方法时，不会实例化该类。只有在需要实例化的时候才构造实例对象。
    /// </summary>
    public sealed class Singleton
    {
        private Singleton()
        {

        }

        public static Singleton GetInstance
        {
            get
            {
                return Nested.instance;
            }
        }

        public static void Hello()
        {

        }

        private class Nested
        {
            internal static readonly Singleton instance = null;

            static Nested()
            {
                instance = new Singleton();
            }
        }
    }
}
