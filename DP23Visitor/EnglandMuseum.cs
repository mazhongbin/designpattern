using System;

namespace DP23Visitor
{
    public class EnglandMuseum : Museum
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitEnglandMuseum(this);
        }

        public void Play()
        {
            Console.WriteLine("演奏爱尔兰风琴");
        }
    }
}
