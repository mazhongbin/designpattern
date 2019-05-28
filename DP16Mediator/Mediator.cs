using System.Collections.Generic;

namespace DP16Mediator
{
    public abstract class Mediator
    {
        protected List<Colleague> colleagues = new List<Colleague>();

        public void Register(Colleague colleague)
        {
            this.colleagues.Add(colleague);
        }

        public void Remove(Colleague colleague)
        {
            this.colleagues.Remove(colleague);
        }

        public virtual void Bulletin(string content)
        {
            foreach (var item in colleagues)
            {
                item.ReceiveNotice(content);
            }
        }
    }
}
