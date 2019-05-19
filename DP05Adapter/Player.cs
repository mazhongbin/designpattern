namespace DP05Adapter
{
    public abstract class Player
    {
        public string Name { get; set; }

        public abstract void Attack();

        public abstract void Defense();
    }
}
