namespace DP02AbstractFactory.AbstractFactory
{
    public class LiningFactory : SportsShop
    {
        public override Hat SellHat()
        {
            return new LiningHat();
        }

        public override Shoes SellShoes()
        {
            return new LiningShoes();
        }
    }
}
