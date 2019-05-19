namespace DP04Prototype
{
    public class Build : Prototype
    {
        public override Prototype Clone()
        {
            Prototype newInstance = new Build
            {
                Number = base.Number + 1,
                Address = base.Address
            };
            return newInstance;
        }
    }
}
