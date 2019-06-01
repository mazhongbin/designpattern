using System;

namespace DP23Visitor
{
    public class ChinaMuseum : Museum
    {
        public override void Accept(Visitor visitor)
        {
            this.Dance();
            visitor.VisitChinaMuseum(this);
        }

        private void Dance()
        {
            Console.WriteLine("56个民族，56朵花");
        }

        public void Paint()
        {
            Console.WriteLine("中国的绘画");
        }
    }
}
