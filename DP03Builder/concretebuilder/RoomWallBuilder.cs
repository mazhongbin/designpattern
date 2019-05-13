namespace DP03Builder.concretebuilder
{
    public class RoomWallBuilder : Builder
    {
        public void BuildPart(House house)
        {
            house.Wall = "Normal Wall";
        }
    }
}
