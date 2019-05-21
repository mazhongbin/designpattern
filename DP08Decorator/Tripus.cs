using System;

namespace DP08Decorator
{
    public class Tripus : Decorator
    {
        public override void Decorate()
        {
            Console.WriteLine("树立三脚架，稳定相机");
            base.Decorate();
        }
    }
}
