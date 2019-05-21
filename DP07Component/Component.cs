namespace DP07Component
{
    public abstract class Component
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public abstract void Add(Component part);
        public abstract void Remove(Component part);
        public abstract int TotalPrice();
    }
}
