namespace DP03Builder.concretebuilder
{
    public class RoomBaseBuilder : Builder
    {
        public void BuildPart(House house)
        {
            house.Base = "Normal Base";
        }
    }
}
