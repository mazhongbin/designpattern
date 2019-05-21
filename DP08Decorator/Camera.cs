namespace DP08Decorator
{
    public abstract class Camera : IDecoratable
    {
        public abstract void TakePhoto();

        public void Decorate()
        {
            this.TakePhoto();
        }
    }
}
