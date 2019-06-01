using System;

namespace DP21State
{
    public class BadState : BodyState
    {
        public override void Work()
        {
            Console.WriteLine("工作状态不佳");
        }
    }
}
