using System;

namespace DP16Mediator
{
    public class Customer : Colleague
    {
        public Customer(Mediator mediator)
        {
            base.TheMediator = mediator;
            mediator.Register(this);
        }

        public override void ReceiveNotice(string notice)
        {
            Console.WriteLine($"顾客听到新的通知：{notice}");
        }
    }
}
