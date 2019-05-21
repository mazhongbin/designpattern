using System;

namespace DP07Component
{
    public class Leaf : Component
    {
        public override void Add(Component part)
        {
            throw new InvalidOperationException("本节点不允许该操作"); 
        }

        public override void Remove(Component part)
        {
            throw new InvalidOperationException("本节点不允许该操作"); 
        }

        public override int TotalPrice()
        {
            return this.Price;
        }
    }
}
