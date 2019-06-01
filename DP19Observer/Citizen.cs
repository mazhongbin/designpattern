using System;

namespace DP19Observer
{
    public class Citizen : Observer
    {
        private BadMan _target;

        public Citizen(BadMan badMan)
        {
            _target = badMan;
        }

        public override void Update()
        {
            var location = this._target.CurrentLocation;
            Console.WriteLine($"打110报警，告知坏人在{location}");
        }
    }
}
