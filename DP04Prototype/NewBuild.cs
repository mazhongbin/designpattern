using System;

namespace DP04Prototype
{
    public class NewBuild : ICloneable
    {
        public int Number { get; set; }

        public string Address { get; set; }

        public object Clone()
        {
            return new NewBuild
            {
                Number = this.Number + 1,
                Address = this.Address
            };
        }
    }
}
