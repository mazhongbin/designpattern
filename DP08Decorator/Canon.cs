using System;

namespace DP08Decorator
{
    public class Canon : Camera
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Canon Take Photo"); 
        }
    }
}
