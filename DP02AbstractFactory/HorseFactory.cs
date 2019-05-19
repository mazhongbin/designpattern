namespace DP02AbstractFactory
{
    public class HorseFactory : ToyFactory
    {
        public override Toy ProductToys()
        {
            return new HorseToy();
        }
    }
}
