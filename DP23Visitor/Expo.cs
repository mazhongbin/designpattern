using System.Collections.Generic;

namespace DP23Visitor
{
    public class Expo
    {
        private List<Museum> museums = new List<Museum>();

        public Expo()
        {
            museums.Add(new ChinaMuseum());
            museums.Add(new EnglandMuseum());
        }

        public void WelCome(Visitor visitor)
        {
            foreach (var item in museums)
            {
                item.Accept(visitor);
            }
        }
    }
}
