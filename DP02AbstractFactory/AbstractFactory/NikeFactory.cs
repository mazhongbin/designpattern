namespace DP02AbstractFactory.AbstractFactory
{
    public class NikeFactory : SportsShop
    {
        public override Hat SellHat()
        {
            return new NikeHat();
        }

        public override Shoes SellShoes()
        {
            return new NikeShoes();
        }
    }
}
