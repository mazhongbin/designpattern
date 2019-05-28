using System;

namespace DP16Mediator
{
    public abstract class Colleague
    {
        public Mediator TheMediator { get; set; }

        public abstract void ReceiveNotice(string notice);

        public void PublishNotice(string notice)
        {
            this.TheMediator.Bulletin(notice);
        }
    }
}
