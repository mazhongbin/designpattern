namespace DP08Decorator
{
    public abstract class Decorator : IDecoratable
    {
        public IDecoratable ObjectToDecoratable { get; set; }
        public virtual void Decorate()
        {
            if(this.ObjectToDecoratable !=null)
            {
                ObjectToDecoratable.Decorate();
            }
        }
    }
}
