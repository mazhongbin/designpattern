namespace DP17Iterator.V1
{
    public abstract class Iterator<T>
    {
        public abstract T Next();

        public abstract T Current();

        public abstract bool IsDone { get; }
    }
}
