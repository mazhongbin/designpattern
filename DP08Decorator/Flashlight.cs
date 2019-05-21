using System;

namespace DP08Decorator
{
    public class Flashlight : Decorator
    {
        public override void Decorate()
        {
            Console.WriteLine("闪光灯先闪光");
            base.Decorate();
        }
    }
}
