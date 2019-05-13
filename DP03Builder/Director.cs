using DP03Builder.concretebuilder;
using System.Collections.Generic;

namespace DP03Builder
{
    public class Director
    {
        private List<Builder> Builders = new List<Builder>();

        public Director()
        {
            this.Builders.Add(new RoomBaseBuilder());
            this.Builders.Add(new RoomWallBuilder());
            this.Builders.Add(new RoomRoofBuilder());
        }

        public House BuildHouse()
        {
            House house = new House();
            foreach (var builder in Builders)
                builder.BuildPart(house);
            return house;
        }
    }
}
