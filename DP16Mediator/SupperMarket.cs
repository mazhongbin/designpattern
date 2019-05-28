using System;
using System.Collections.Generic;
using System.Text;

namespace DP16Mediator
{
    public class SupperMarket : Mediator
    {
        public override void Bulletin(string content)
        {
            Console.WriteLine($"超市发布新的公告：{content}");
            base.Bulletin(content);
        }

        public void Promote()
        {
            this.Bulletin("中秋大促销");
        }
    }
}
