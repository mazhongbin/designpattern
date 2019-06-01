using System;

namespace DP22Strategy
{
    public class Discount : Strategy
    {
        public override void Algorith(ref double currentTotal)
        {
            Console.WriteLine("打折啦");
            currentTotal *= 0.91;
        }
    }
}
