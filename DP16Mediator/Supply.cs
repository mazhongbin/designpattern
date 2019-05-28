using System;

namespace DP16Mediator
{
    public class Supply : Colleague
    {
        public Supply(Mediator mediator)
        {
            base.TheMediator = mediator;
            mediator.Register(this);
        }

        public override void ReceiveNotice(string notice)
        {
            Console.WriteLine($"供应商听到消息：{notice}");
        }
    }
}
