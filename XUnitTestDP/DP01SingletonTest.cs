using System.Threading.Tasks;
using Xunit;

namespace XUnitTestDP
{
    public class DP01SingletonTest
    {
        [Fact]
        public void SingletonV1_SingleThread()
        {
            DP01Singleton.V1.Singleton singleton1 = DP01Singleton.V1.Singleton.GetInstance;
            DP01Singleton.V1.Singleton singleton2 = DP01Singleton.V1.Singleton.GetInstance;

            Assert.Same(singleton1, singleton2);
        }

        [Fact]
        public void SingletonV1_MultiThread()
        {
            DP01Singleton.V1.Singleton singleton1 = null;
            DP01Singleton.V1.Singleton singleton2 = null;
            Task.Run(() =>
            {
                singleton1 = DP01Singleton.V1.Singleton.GetInstance;
                singleton2 = DP01Singleton.V1.Singleton.GetInstance;

            });

            Assert.Same(singleton1, singleton2);
        }
    }
}
