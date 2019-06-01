using System;

namespace DP19Observer
{
    public class PoliceMan : Observer
    {
        private BadMan _target;

        public PoliceMan(BadMan badMan)
        {
            _target = badMan;
        }
        public override void Update()
        {
            var location = _target.CurrentLocation;
            Console.WriteLine($"在{location}部署警力");
        }
    }
}
