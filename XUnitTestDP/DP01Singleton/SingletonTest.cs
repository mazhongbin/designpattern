using DP01Singleton.V1;
using Xunit;

namespace XUnitTestDP.DP01Singleton
{
    public class SingletonTest
    {
        [Fact]
        public void SingletonV1()
        {
            Singleton singleton1 = Singleton.GetInstance;
            Singleton singleton2 = Singleton.GetInstance;

            Assert.Same(singleton1, singleton2);
        }
    }
}
