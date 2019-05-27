using System;

namespace DP14Command
{
    public class OrderCommand : Command
    {
        private WebService receiver = new WebService();
        private Guid id = Guid.Empty;

        public OrderCommand()
        {
            this.id = Guid.NewGuid();
        }

        public override Guid CommandId
        {
            get { return this.id; }
        }

        public override void Execute()
        {
            receiver.NewOrder(this.OrderNumber, this.Total, this.Customer);
        }

        public int Total { get; set; }
        public Guid OrderNumber
        {
            get { return this.CommandId; }
        }

        public string Customer { get; set; }
    }
}
