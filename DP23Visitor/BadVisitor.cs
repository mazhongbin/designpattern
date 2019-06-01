using System;

namespace DP23Visitor
{
    public class BadVisitor : Visitor
    {
        public override void VisitChinaMuseum(ChinaMuseum chinaMuseum)
        {
            chinaMuseum.Paint();
            Console.WriteLine("吹口哨");
        }

        public override void VisitEnglandMuseum(EnglandMuseum englandMuseum)
        {
            englandMuseum.Play();
            Console.WriteLine("不文明行为");
        }
    }
}
