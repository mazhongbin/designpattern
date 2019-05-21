using System.Collections.Generic;

namespace DP07Component
{
    public class Composite : Component
    {
        private List<Component> components = new List<Component>();
        public override void Add(Component part)
        {
            components.Add(part);
        }

        public override void Remove(Component part)
        {
            components.Remove(part);
        }

        public override int TotalPrice()
        {
            int total = this.Price;
            foreach (var item in components)
            {
                total += item.TotalPrice();
            }
            return total;
        }
    }
}
