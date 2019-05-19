namespace DP02AbstractFactory
{
    public class CarFactory : ToyFactory
    {
        public override Toy ProductToys()
        {
            return new CarToy();
        }
    }
}
