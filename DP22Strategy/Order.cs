namespace DP22Strategy
{
    public class Order
    {
        private double _total;
        public Order(double total)
        {
            _total = total;
        }

        public void UsePromote(Strategy strategy)
        {
            strategy.Algorith(ref _total);
        }
    }
}
