using System;

namespace DP23Visitor
{
    public class GoodVisitor : Visitor
    {
        public override void VisitChinaMuseum(ChinaMuseum chinaMuseum)
        {
            Console.WriteLine("崇拜的看舞蹈");
            chinaMuseum.Paint();
        }

        public override void VisitEnglandMuseum(EnglandMuseum englandMuseum)
        {
            Console.WriteLine("风笛真好听");
            englandMuseum.Play();
        }
    }
}
