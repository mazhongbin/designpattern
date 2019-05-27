using System;

namespace DP14Command
{
    public class WebService
    {
        public void NewOrder(Guid orderNumber,int total,string customer)
        {
            Console.WriteLine($"{customer}在{DateTime.Now}下订单，订单金额为{total},订单编号为{orderNumber}");
        }
    }
}
