namespace DP04Prototype
{
    public abstract class Prototype
    {
        public int Number { get; set; }

        public string Address { get; set; }

        public abstract Prototype Clone();
    }
}
