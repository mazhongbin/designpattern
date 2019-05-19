using System;

namespace DP05Adapter
{
    public class USAPlayer : Player
    {
        public override void Attack()
        {
            Console.WriteLine("USA Player Attack.");
        }

        public override void Defense()
        {
            Console.WriteLine("UAS Player Defense.");
        }
    }
}
